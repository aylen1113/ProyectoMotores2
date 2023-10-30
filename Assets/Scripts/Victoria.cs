using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Victoria : MonoBehaviour
{
    public Text mensajeVictoria; 
    private GameObject[] enemigos;

    void Start()
    {
        enemigos = GameObject.FindGameObjectsWithTag("Bot");
        mensajeVictoria.gameObject.SetActive(false); 
    }

    void Update()
    {
        if (TodosEnemigosDestruidos())
        {
           
            mensajeVictoria.gameObject.SetActive(true); 
            Debug.Log("Todos los enemigos han sido destruidos");
        }
    }

    bool TodosEnemigosDestruidos()
    {
        foreach (GameObject enemigo in enemigos)
        {
            if (enemigo != null)
            {
                return false;
            }
        }

        return true;
    }
}