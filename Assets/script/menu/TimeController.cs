using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;


public class TimeController : MonoBehaviour
{

    public GameObject menuPausa; // un menu de pausa
    public float scaleAtRuntime; // el tiempo actual
    public void HandleTime() // el que va a controlar todo

{
    if (Time.timeScale != 0 ) // si el tiempo es diferente a 0
    {
        Pause();//llama al metodo resume
    }
        else //si no
        {
            Resume(); //llama al metodo resume
        }
    
}
public void Pause ()
{
scaleAtRuntime = Time.timeScale;// nos guarda el tiempo
Time.timeScale = 0; // pone el tiempo a 0
menuPausa.SetActive(true); // activa el menu de pausa
}

public void Resume()
{
    Time.timeScale= scaleAtRuntime; //recupera el tiempo guardado
    menuPausa.SetActive(false); // desactiva el menu de pausa
    EventSystem.current.SetSelectedGameObject(null); // deselecciona el boton despues de hacerle click
}

}

