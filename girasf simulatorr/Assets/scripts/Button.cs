using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _trykHer;
    public void trykHer()
    {
        Debug.Log("Hej");
    }
}