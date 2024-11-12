﻿using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_repeats, _loopType);
    }
}
