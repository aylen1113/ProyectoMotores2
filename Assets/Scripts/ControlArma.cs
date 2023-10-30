using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlArma : MonoBehaviour
{
    public Transform camaraPrimeraPersona;
    public float rango = 200;
    public LayerMask capas;
    public GameObject proyectil;

    private void Update()
    {
        HandleShoot();
    }
    private void HandleShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = new Ray(camaraPrimeraPersona.position, camaraPrimeraPersona.forward);

            if (Physics.Raycast(ray, out hit, rango, capas))
            {
                GameObject pro;
                pro = Instantiate(proyectil, ray.origin, transform.rotation);

                Rigidbody rb = pro.GetComponent<Rigidbody>();
                rb.AddForce(camaraPrimeraPersona.transform.forward * 15, ForceMode.Impulse);

                Destroy(pro, 5);

                Debug.Log("Disparo");

                if (hit.collider.gameObject.CompareTag("Bot"))
                {
                    GameObject objetoTocado = hit.collider.gameObject;
                    ControlBot scriptObjetoTocado = objetoTocado.GetComponent<ControlBot>();

                    if (scriptObjetoTocado != null)
                    {
                        scriptObjetoTocado.Damage();
                    }
                }
            }
        }
    }
}



