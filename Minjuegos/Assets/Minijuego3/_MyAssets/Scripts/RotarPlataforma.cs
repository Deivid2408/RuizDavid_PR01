using UnityEngine;

public class RotarPlataforma : MonoBehaviour
{
    // Qué tan fuerte gira la plataforma
    public float fuerzaRotacion = 1f;   

    private Rigidbody rb;

    void Start()
    {

        // Obtenemos el Rigidbody de la plataforma
        rb = GetComponent<Rigidbody>();  
    }

    void FixedUpdate()
    {

       Movimiento();
    }

    public void Movimiento()
    {
        //Joystick izquierdo
        float horizontalIzq = Input.GetAxis("Horizontal");


        //Joystick derecho
        float verticalDer = Input.GetAxis("Vertical");


        Vector3 push = new Vector3(horizontalIzq, 0, verticalDer);

        //Rotación con joystick izquierdo
        rb.AddTorque(push * horizontalIzq * fuerzaRotacion);

        //Rotación con joystick derecho
        rb.AddTorque(push * verticalDer * fuerzaRotacion);
    }
}