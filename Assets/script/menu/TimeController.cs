using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;


public class TimeController : MonoBehaviour
{

    public GameObject menuPausa; // un menu de pausa
    public float scaleRuntime; // el tiempo actual
    public void HandleTime() // el que va a controlar todo

{
    if (Time.timeScale != 0 ) // si el tiempo es diferente a 0
    {
        Pause();//llqmq ql metodo resume
    }
}
public void Pause ()
{
scaleAtRuntime = Time.timeScale;
Time.timescale = 0; // pone el tiempo a 0
menuPausa.SetActive(true); // activa el menu de pausa
}

public void Resume()
{
    Time.timescale= scaledAtRuntime; //recupera el tiempo guardado
    menuPausa.SetActive(False); // reactiva el menu de pausa
    EventSystem.current.SetSelectedGameObject(null); // deselecciona el boton despues de hacerle click
}

}

