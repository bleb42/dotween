using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Update()
    {
        transform.DOMoveZ(transform.position.z + 1, _duration).SetLoops(-1, LoopType.Restart);
    }
}