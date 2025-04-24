using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingChanging : MonoBehaviour
{
    private Animator animator;
   /* private Rigidbody rigidbody;*/
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

       /* rigidbody = GetComponentInParent<Rigidbody>();*/
    }

    // Update is called once per frame
    void Update()
    {
       /* animator.SetFloat("Speed",rigidbody.velocity.magnitude);*/


        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("IsShooting", true);
            PlayerSoundManager.Instance.PlayFireSound();
        }
        else
        {
            animator.SetBool("IsShooting", false);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            animator.SetBool("Reloading", true);
            PlayerSoundManager.Instance.PlayReloadSound();
        }
        else
        {
            animator.SetBool("Reloading", false);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            animator.SetTrigger("ThrowGranad");
        }

        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("IsDead", true);
        }
        else
        {
            animator.SetBool("IsDead", false);
        }





        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsWalkingSlow", true);
        }
        else
        {
            animator.SetBool("IsWalkingSlow", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("WalkLeft", true);
        }
        else
        {
            animator.SetBool("WalkLeft", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("WalkRight", true);
        }
        else
        {
            animator.SetBool("WalkRight", false);
        }



        if (Input.GetKey(KeyCode.M))
        {
            animator.SetBool("IsOneArmShot", true);
        }
        else
        {
            animator.SetBool("IsOneArmShot", false);
        }

        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool("IsWCr", true);
        }
        else
        {
            animator.SetBool("IsWCr", false);
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            animator.SetBool("IsShootLie", true);
        }
        else
        {
            animator.SetBool("IsShootLie", false);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("IsSitting", true);
        }
        else
        {
            animator.SetBool("IsSitting", false);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsCrouching", true);
        }
        else
        {
            animator.SetBool("IsCrouching", false);
        }

        if(Input.GetKey(KeyCode.S))
        {
            animator.SetBool("IsWalkingBack", true);
        }
        else
        {
            animator.SetBool("IsWalkingBack", false);
        }
    }

}

