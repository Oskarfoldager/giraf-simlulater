using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class timerthing : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public float period = 20f;
    private float nextactiontime = 0;
    public static int time = 0;
    public static bool gamesisactive = false;
    public GameObject camera;

    public GameObject button;


    // Start is called before the first frame update
    void Update()
    {
        if (gamesisactive == true)
        {
            button.SetActive(false);
            camera.SetActive(false);
            if (Time.time > nextactiontime)
            {
                Debug.Log("times go uppie adam sysa do0wniie" + time);
                nextactiontime += period;
                time += 1;

            }
        }
        else
        {
            button.SetActive(true);
            camera.SetActive(true);
        }
        if(time >= 20)
        {
            gamesisactive = false;
            foreach (GameObject gameobj in GameObject.FindGameObjectsWithTag("trashcan")) {
              Destroy(gameobj);
            }
        }


    }
    void Start()
    {
        gamesisactive = false;
    }
}
