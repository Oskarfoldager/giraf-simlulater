using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerthing : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public float period = 20f;
    private float nextactiontime = 0;
    public int time = 0;
    public bool gamesisactive = false;

    // Start is called before the first frame update
    void Update()
    {
        if (gamesisactive == true)
        {
            if (Time.time > nextactiontime)
            {
                Debug.Log("times go uppie adam sysa do0wniie" + time);
                nextactiontime += period;
                time = +1;

            }
        }
        if(time >= 20)
        {
            gamesisactive = false;
        }


    }
}
