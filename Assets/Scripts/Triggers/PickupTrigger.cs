using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : Trigger
{
    private void OnDestroy()
    {
        SetTrigger();
    }
}
