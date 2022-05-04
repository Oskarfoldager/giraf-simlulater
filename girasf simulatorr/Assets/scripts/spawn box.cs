using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbox : MonoBehaviour
{
    public GameObject playerr;
    public Vector3 randomposition;


    void Update()
    {


            Debug.Log("Attempting to spawn enemy");
            GameObject thisproj = Instantiate(playerr, transform.position = randomposition, transform.rotation);



    }
}
