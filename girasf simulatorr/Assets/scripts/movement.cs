using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            rb.AddForce(Vector3.up * 8, ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            rb.MovePosition(new Vector3(rb.position.x , rb.position.y, rb.position.z - (float)speed));
            transform.eulerAngles = new Vector3(0f, 180f, 0f);

        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            rb.MovePosition(new Vector3(rb.position.x , rb.position.y, rb.position.z + (float)speed));
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
        {

            rb.MovePosition(new Vector3(rb.position.x - (float)speed, rb.position.y, rb.position.z));
            transform.eulerAngles = new Vector3(0f, -90f, 0f);

        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        {

            rb.MovePosition(new Vector3(rb.position.x + (float)speed, rb.position.y, rb.position.z));
            transform.eulerAngles = new Vector3(0f, 90f, 0f);

        }
    }

}
