using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspawner : MonoBehaviour
{
    public GameObject player;
    public float eds = 1;

    // Start is called before the first frame update
    void start()
    {

    }
    private void Update()
    {
        if (eds == 1)
        {
            Debug.Log("Attempting to spawn player");
            GameObject thisproj = Instantiate(player, transform.position, transform.rotation);
            eds = 2;
        }
    }
}
