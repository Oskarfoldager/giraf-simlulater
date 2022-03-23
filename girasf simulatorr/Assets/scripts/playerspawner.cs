using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspawner : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void start()
    {
            Debug.Log("Attempting to spawn player");
            GameObject thisproj = Instantiate(player, transform.position, transform.rotation);
    }
}
