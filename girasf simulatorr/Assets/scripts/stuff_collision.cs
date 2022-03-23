using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stuff_collision : MonoBehaviour
{
    public Rigidbody rb;
    public int Forceamount = 12;
    public static int points = 0;

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.other.tag == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("hit something");
            rb.AddForce(Vector3.up * Forceamount, ForceMode.VelocityChange);
            points += 1;
        }

    }

}