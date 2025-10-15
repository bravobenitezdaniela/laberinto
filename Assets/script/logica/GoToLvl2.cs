using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GoToLvl2 : MonoBehaviour

{
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("se tocan :$");
        if (collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("2", LoadSceneMode.Single);
        }
    }
}
