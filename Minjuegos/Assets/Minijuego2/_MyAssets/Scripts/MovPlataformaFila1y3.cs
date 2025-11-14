using UnityEngine;

public class MovPlataformaFila1y3 : MonoBehaviour
{
    //Esta variable nos permitirá ajustar la fuerza de rotación desde el Inspector de Unity
    public float fuerzaRotacion = 30f;


    //Siempre que vayamos a trabajar con físicas, necesitamos una referencia al Rigidbody
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Nada más empezar el juego, le digo que detecte el Rigidbody que tiene este objeto
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Esto será mi movimiento de mi joystick 
        float rotacion = Input.GetAxis("Horizontal");
        rb.AddTorque(Vector3.back * rotacion * fuerzaRotacion);


    }
}
