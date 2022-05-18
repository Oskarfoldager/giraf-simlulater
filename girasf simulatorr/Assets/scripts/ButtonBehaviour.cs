using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    //  int n;
    //  public GameObject player;
    //public playerspawner playerspawner;

    public void OnButtonPress()
    {
        //  n++;
        //    Debug.Log("Button clicked " + n + " times.");

        //  GameObject thisproj = Instantiate(player, transform.position, transform.rotation);
        Debug.Log("BUTTON PRESSED");
        GameObject.FindObjectOfType<playerspawner>().Pressspawn();
        //  gameObject.GetComponent<timerthing>().gamesisactive = true;
        timerthing.gamesisactive = true;
        //  playerspawner.Pressspawn();

    }
}