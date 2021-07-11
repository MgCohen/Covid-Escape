using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Collider))]
public class TouchTrigger : Trigger, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        SetTrigger();
    }
}
