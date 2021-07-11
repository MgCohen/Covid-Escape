using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public Animator anim;
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
            else if (speed.y <= 0)
            {
                speed.y = -1;
                anim.SetBool("Jumping", false);
            }


            speed.x = moveSpeed;

            if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
            {
                speed.y = jumpSpeed;
                anim.SetBool("Jumping", true);
            }

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
        anim.SetBool("Dash", true);
        var oldSpeed = speed;
        speed = new Vector3(dashSpeed, 0, 0);
        controller.height = 1f;
        if (controller.isGrounded)
        {
            controller.enabled = false;
            //transform.position += Vector3.down / 2;
            controller.enabled = true;
        }
        yield return new WaitForSeconds(0.3f);
        controller.height = 2;
        speed = oldSpeed;
        anim.SetBool("Dash", false);
        dashing = false;
    }

    public void Vaccine()
    {

    }


}
