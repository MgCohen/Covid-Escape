using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFunctionObject : Triggerable
{

    public MonoBehaviour component;

    public override void Trigger()
    {
        component.enabled = !component.enabled;
    }
}
