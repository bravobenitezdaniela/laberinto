using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject loseText; //el panel de ganar
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hola? uwu");
        if (collider.CompareTag("Player"))
        {
            loseText.SetActive(true);
        }
    }
}
