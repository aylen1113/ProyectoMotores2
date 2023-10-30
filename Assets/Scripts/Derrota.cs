using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Derrota : MonoBehaviour

{
    public Text mensajeDerrota;
    public float tiempoTranscurrido = 0f;
public float tiempoLimite = 30f;

    // Start is called before the first frame update
    void Start()
    {
        mensajeDerrota.gameObject.SetActive(false);
    }

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= tiempoLimite)
        {
            mensajeDerrota.gameObject.SetActive(true);
            Debug.Log("Game over");
            
        }
    }
}
   
