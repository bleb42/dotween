using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotatingDuration;

    private void Update()
    {
        transform.DORotate(new Vector3(0, 360, 0), _rotatingDuration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetRelative();
    }
}
