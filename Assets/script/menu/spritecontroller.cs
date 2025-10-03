using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spritecontroller : MonoBehaviour
{
  public GameObject Pausa; //boton
  public Sprite pauseSprite;
  public Sprite playSprite;
  void Start ()
    {
        Pausa = gameObject;
        Sprite Load(string imageName, string spriteName) 
        {

        Sprite[] all = Resources.LoadAll<Sprite>(imageName);
       foreach (var  s in all)
       {
        
    
            if (s.name == spriteName)
        {
            return s;
        }
    }
    return null;
        }
    playSprite = Load ("play_pausa", "Play");
pauseSprite = Load ("play_pausa", "Pausa" );
//nombre de la variable = carga (nombre de la imagen, nombre del sector, es decir, sprite)

}

void Update()
{
    if (Time.timeScale == 0)
    {
                Pausa.GetComponent<Image>().sprite = playSprite;

    }
    else
    {
        Pausa.GetComponent<Image>().sprite = pauseSprite;
    
    }
   
}
}
