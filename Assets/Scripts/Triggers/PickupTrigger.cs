using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : Trigger
{

    [ContextMenu("test")]
    public void test()
    {
        SetTrigger();
    }


    private void OnDestroy()
    {
        SetTrigger();
    }
}
