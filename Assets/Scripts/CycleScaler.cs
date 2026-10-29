using DG.Tweening;
using UnityEngine;

public class CycleScaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale = new(3, 2, 3);
    [SerializeField] private float _duration = 2;

    void Start()
    {
        transform.DOScale(_scale, _duration).SetEase(Ease.InOutElastic).SetLoops(-1, LoopType.Yoyo).Play();
    }
}
