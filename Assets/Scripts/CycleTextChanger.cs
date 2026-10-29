using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CycleTextChanger : MonoBehaviour
{
    [Header("Первое изменение")]
    [SerializeField] private string _firstText = "Другая строка";
    [SerializeField] private float _firstDuration = 2f;
    [SerializeField] private ScrambleMode _firstScrambleMode = ScrambleMode.None;
    [SerializeField] private Color _firstColor = Color.white;
    
    [Header("Второе изменение")]
    [SerializeField] private string _secondText = "Другая строка 2";
    [SerializeField] private float _secondDuration = 2f;
    [SerializeField] private ScrambleMode _secondScrambleMode = ScrambleMode.Numerals;
    [SerializeField] private Color _secondColor = Color.white;

    [Header("Третье изменение")]
    [SerializeField] private string _thirdText = "Другая строка 3";
    [SerializeField] private float _thirdDuration = 2f;
    [SerializeField] private ScrambleMode _thirdScrambleMode = ScrambleMode.Uppercase;
    [SerializeField] private Color _thirdColor = Color.white;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_firstText, _firstDuration, scrambleMode: _firstScrambleMode))
            .Join(_text.DOColor(_firstColor, _firstDuration))

            .Append(_text.DOText(_secondText, _secondDuration, scrambleMode: _secondScrambleMode))
            .Join(_text.DOColor(_secondColor, _secondDuration))

            .Append(_text.DOText(_thirdText, _thirdDuration, scrambleMode: _thirdScrambleMode))
            .Join(_text.DOColor(_thirdColor, _thirdDuration))

            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear)
            .Play();
    }
}
