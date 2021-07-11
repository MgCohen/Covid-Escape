using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperCollision : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var jumper = hit.transform.GetComponent<Jumper>();
        Debug.Log(2);
        if (jumper) jumper.Jump(GetComponent<Player>());
    }
}
