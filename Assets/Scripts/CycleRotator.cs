using DG.Tweening;
using UnityEngine;

public class CycleRotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation = new(45, 0, 90);
    [SerializeField] private float _duration = 2;
    
    void Start()
    {
        transform.DORotate(_rotation, _duration).SetEase(Ease.InOutFlash).SetLoops(-1, LoopType.Yoyo).Play();
    }
}
