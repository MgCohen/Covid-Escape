using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LoopMovableObjects : MonoBehaviour
{
    public Vector3 move;
    public float delayBetweenMoves;
    public float moveDuration;

    private void Start()
    {
        DoMove();
    }

    void DoMove()
    {
        transform.DOMove(transform.position + move, moveDuration).SetDelay(delayBetweenMoves).OnComplete(UndoMove);
    }


    void UndoMove()
    {
        transform.DOMove(transform.position - move, moveDuration).SetDelay(delayBetweenMoves).OnComplete(DoMove);
    }

    private void OnDestroy()
    {
        transform.DOKill();
    }
}
