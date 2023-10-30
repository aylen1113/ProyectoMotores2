using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;
    public float rapidez = 1.0f;
    private GameObject jugador;

    void Start()
    {
        hp = 100;
      jugador = GameObject.Find("Jugador");
      
    }

    private void Update() 
    {
        transform.LookAt(jugador.transform); 
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime); 
    }

public void Damage()
    {
        hp = hp - 25;

        if (hp <= 0) 

        {
        this.Desaparecer();
        }
    }
    private void Desaparecer()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision) 
    { 
        if (collision.gameObject.CompareTag("bala")) 
        {

            Damage();
                
          } 
    }
}


