using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimition : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        {

            animator.SetBool("IsWalking", true);

        }
       if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.D))
        {

           animator.SetBool("IsWalking", false);

       }

    }




}
