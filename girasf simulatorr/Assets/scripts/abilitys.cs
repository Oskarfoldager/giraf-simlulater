using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitys : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)))
        {
            turnplayer();
        }

       
    }
    public void turnplayer()
    {
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }

}
