using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _textToChange;
    [SerializeField] private float _duration;

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        _text.DOText(_textToChange, _duration, true, ScrambleMode.All);
    }
}
