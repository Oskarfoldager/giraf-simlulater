using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject player;
    public GameObject trash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if( timerthing.gamesisactive == false)
        {
            player.transform.position = new Vector3(800f, 200f, 869f);
            player.transform.position = new Vector3(869f, 200f, 100f);
            Debug.Log("stopped");
        }
    }
}
