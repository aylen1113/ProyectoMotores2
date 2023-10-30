using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public float tiempoLimite = 30f;
    private float tiempo = 0f;
    public Text textoTiempo;

    void Update()
    {
        tiempo += Time.deltaTime;

        textoTiempo.text = "Tiempo: " + Mathf.Round(tiempo).ToString();

        if (tiempo >= tiempoLimite)
        {
            Debug.Log("Game over");
        }
    }
}
