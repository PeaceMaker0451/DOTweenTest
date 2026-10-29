using DG.Tweening;
using UnityEngine;

public class CycleMover : MonoBehaviour
{
    [SerializeField] private Vector3 _move = Vector3.one;
    [SerializeField] private float _duration = 2f;
    
    void Start()
    {
       transform.DOMove(transform.position + _move, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo).Play();
    }
}
