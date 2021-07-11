using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public Transform model;

    public float jumpSpeed;
    public float moveSpeed;
    public float dashSpeed;
    public float gravity;

    public Vector3 speed;

    bool dashing = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        if (!dashing)
        {

            if (!controller.isGrounded) speed.y -= gravity;
            else if (speed.y <= 0) speed.y = -1;


            speed.x = moveSpeed;

            if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded) speed.y = jumpSpeed;

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Dash();
            }
        }
        controller.Move(speed * Time.deltaTime);

    }

    public void AddSpeed(Vector3 direction)
    {
        speed += direction;
    }

    public void Dash()
    {
        StartCoroutine(Dashing());
    }

    IEnumerator Dashing()
    {
        dashing = true;
        var oldSpeed = speed;
        speed = new Vector3(dashSpeed, 0, 0);
        var scale = model.localScale;
        scale.y = 1f;
        model.localScale = scale;
        controller.height = 1f;
        if (controller.isGrounded)
        {
            controller.enabled = false;
            transform.position += Vector3.down / 2;
            controller.enabled = true;
            Debug.Log(2);
        }
        yield return new WaitForSeconds(0.3f);
        scale.y = 2f;
        model.localScale = scale;
        controller.height = 2;
        speed = oldSpeed;
        dashing = false;

    }

    public void Vaccine()
    {

    }


}
