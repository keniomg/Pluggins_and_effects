using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _startText;
    [SerializeField] private string _firstReplacingText;
    [SerializeField] private string _secondReplacingText;
    [SerializeField] private string _additionalText;
    [SerializeField] private string _hackingText;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_startText.DOText(_firstReplacingText, _duration))
            .Append(_startText.DOText(_additionalText, _duration).SetRelative())
            .Append(_startText.DOText(_secondReplacingText, _duration))
            .Append(_startText.DOText(_hackingText, _duration, false, ScrambleMode.All));

        sequence.SetLoops(_repeats, _loopType);
    }
}