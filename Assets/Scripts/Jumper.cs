using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Vector3 jumpForce;

    public void Jump(Player player)
    {
        player.controller.detectCollisions = false;
        player.transform.position += Vector3.up;
        player.AddSpeed(jumpForce);
        Debug.Log(1);
    }

}
