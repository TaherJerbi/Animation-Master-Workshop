using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trump : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        //  Make sure all the transition have 0 exit time

        animator.SetBool("Up", Input.GetKeyDown(KeyCode.UpArrow));
        animator.SetBool("Down", Input.GetKeyDown(KeyCode.DownArrow));
        animator.SetBool("Right", Input.GetKeyDown(KeyCode.RightArrow));
        animator.SetBool("Left", Input.GetKeyDown(KeyCode.LeftArrow));


        // You can use trigger to achieve the same effect
    }
}
