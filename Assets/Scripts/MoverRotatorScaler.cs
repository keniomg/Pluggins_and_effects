using DG.Tweening;
using UnityEngine;

public class MoverRotatorScaler : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(_endPosition, _duration))
            .Insert(0f, transform.DOScale(_scale, _duration))
            .Insert(0f, transform.DORotate(_rotation, _duration));
            
        sequence.SetLoops(_repeats, _loopType);
    }
}