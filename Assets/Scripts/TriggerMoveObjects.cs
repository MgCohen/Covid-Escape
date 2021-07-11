using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerMoveObjects : Triggerable
{
    public Vector3 move;
    public float moveDuration;

    bool isUsed = false;

    public override void Trigger()
    {
        if (isUsed)
        {
            transform.DOMove(transform.position + move, moveDuration);
        }
        else
        {
            transform.DOMove(transform.position - move, moveDuration);
        }

        isUsed = !isUsed;
    }

}
