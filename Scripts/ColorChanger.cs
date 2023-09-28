using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _changingDuration = 5f;

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        _text.DOColor(_targetColor, _changingDuration);
    }
}
