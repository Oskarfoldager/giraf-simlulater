using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspawner : MonoBehaviour
{
   public Rigidbody rb;
    int n = 0;
    public GameObject trashcan;
    public int trashcannumber = 100;
    public GameObject camera;
    public GameObject player;
            public GameObject button;


    public void Start()
    {
        camera.SetActive(true);
        player.transform.position = new Vector3(100, -10, 100);
    }

    public void Pressspawn()
    {

        for (int i = 0; i < trashcannumber; i++)
        {
            Debug.Log("Creating new trashcan " + i);
            var position = new Vector3(Random.Range(-50f, 50f), 0, Random.Range(-50f, 50f));
            Instantiate(trashcan, position, Quaternion.identity);
        }

        button.SetActive(false);
        camera.SetActive(false);
        player.transform.position = new Vector3(0,0,0);

        n++;
        Debug.Log("Button clicked " + n + " times.");

      //  rb.position = startpos;
    //    rb.velocity = Vector3.zero;
     //   transform.eulerAngles = new Vector3(0f, 0f, 0f);
        //Instantiate(trashcan, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z) + transform.forward, transform.rotation);
   
    }

}
