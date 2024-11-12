using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _moveTime;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_endPosition, _moveTime).SetLoops(_repeats, _loopType);
    }
}
