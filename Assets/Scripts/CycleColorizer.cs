using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class CycleColorizer : MonoBehaviour
{
    [SerializeField] private Color _color = Color.cyan;
    [SerializeField] private float _duration = 2;

    private MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetEase(Ease.InOutExpo).SetLoops(-1, LoopType.Yoyo).Play();
    }
}
