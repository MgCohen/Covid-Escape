using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Triggerable triggerable;

    public void SetTrigger()
    {
        triggerable?.Trigger();
    }
}
