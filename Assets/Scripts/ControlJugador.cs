using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador: MonoBehaviour
{
public float rapidezDesplazamiento = 10.0f;
public Camera camaraPrimeraPersona;

    void Start()
{
    Cursor.lockState = CursorLockMode.Locked;
}
void Update()
{
    float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
    float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;
    movimientoAdelanteAtras *= Time.deltaTime;
    movimientoCostados *= Time.deltaTime;
    transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        Cursor.lockState = CursorLockMode.None;
    }


    }
}




