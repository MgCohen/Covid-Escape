using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnableObjects : Triggerable
{
    public override void Trigger()
    {
        var active = gameObject.activeInHierarchy;
        gameObject.SetActive(!active);
    }
}
