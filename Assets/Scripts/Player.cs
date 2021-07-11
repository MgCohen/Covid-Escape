using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public Transform model;

    public float jumpSpeed;
    public float moveSpeed;
    public float gravity;

    public Vector3 speed;

    private void Update()
    {
        if (!controller.isGrounded) speed.y -= gravity;
        else speed.y = -1;


        speed.x = moveSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded) speed.y = jumpSpeed;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            var scale = model.localScale;
            scale.y = 1f;
            model.localScale = scale;
            controller.height = 1f;
            transform.position += Vector3.down;
        }

        controller.Move(speed * Time.deltaTime);

    }

    public void AddSpeed(Vector3 direction)
    {
        speed += direction;
    }


}
