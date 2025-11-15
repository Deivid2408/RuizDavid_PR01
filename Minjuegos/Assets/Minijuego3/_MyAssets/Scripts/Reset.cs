using System;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Vector3 spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Respawn();
    }

    void Respawn()
    {
        if (transform.position.y < -30)
        {
            transform.position = spawn;

            //Detener la velocidad del objeto al resetear su posicion y no acumule velocidad
            //rb.Sleep();

        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fallo"))
        {
            print("Has fallado");


        }

    }



}
