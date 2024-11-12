using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_rotation, _duration).SetLoops(_repeats, _loopType);
    }
}
