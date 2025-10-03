using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class win1: MonoBehaviour
{
  public GameObject winText ; // el panel de ganar 
  public void OnTriggerEnter(Collider collider)
  {
    Debug.Log("Holaaa");
    if (collider.CompareTag ("Player"))
{
    winText.SetActive (true);
}
}
}