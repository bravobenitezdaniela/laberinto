using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ; // encargado de la UI
using UnityEngine.EventSystems; // encargado del Canvas
using UnityEngine.ScreenManagement; // encargado de poder cambiar de escenas
public class scenes : MonoBehaviour
{
 public void Play ()
{
    SceneManager.LoadScene ( "SampleScene", LoadSceneMode.Single);
}
}
