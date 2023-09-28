using UnityEngine;
using DG.Tweening;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _growingDuration;

    private void Update()
    {
        transform.DOScale(transform.localScale.y + 1, _growingDuration).SetLoops(-1, LoopType.Restart);
    }
}
