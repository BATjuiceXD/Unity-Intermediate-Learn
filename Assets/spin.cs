using UnityEngine;
using PrimeTween;

public class RotatePingPong : MonoBehaviour
{
    bool isForward = true;

    void Start()
    {
        StartTween();
    }

    void StartTween()
    {
        Tween.PositionY(transform, transform.position.y + 0.25f,1f, cycles: 999999 , cycleMode: CycleMode.Yoyo);
    }
}
