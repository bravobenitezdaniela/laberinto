using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f; //velocidad 
    private Rigidbody playerb; //Rigidbody que nos pemite movernos
    private Vector3 moveInput; // vector de 3D
    public float speedJump = 2f;
    void Start()
    {
        playerb = GetComponent<Rigidbody>(); // pillamos el rb para poder movernos 
    }

   
    void Update()
    {
        float moveX = Input. GetAxisRaw ("Horizontal"); // pille el movimiento de manera horizontal y los vincule solo a las teclas de este , es decir flechas laterales y a d 
        float moveZ = Input. GetAxisRaw ("Vertical"); //lo mismo pero con las flechas ariba abajo y ws
        moveInput = new Vector3 (moveX, 0 , moveZ); // le asignamos los movimientos a los parámetros // salto
        if(Input.GetKey ("space")) // cuando apretas el espacio y la velocidad en y es cero , añadimos fuerza y nos hace saltar
        {
            playerb.AddForce (transform.up* speedJump);
            Debug.Log("Salto lol");//para la consola
        }
        
    }
     
    private void FixedUpdate()
    
    {
        playerb.MovePosition(playerb.position + moveInput.normalized *speed * Time.fixedDeltaTime);

    }
}