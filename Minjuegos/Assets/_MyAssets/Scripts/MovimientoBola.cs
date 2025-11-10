using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public class MovimientoBola : MonoBehaviour
{
    Rigidbody rb;
    Vector3 push = Vector3.forward;

    float moveforce = 50f;
    float torqueforce = 20f;

    [SerializeField] float thrust = 20f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Rotacion();
        rb.AddForce(push * moveforce);
    }

    void Move()
    {
        rb.AddForce(push * moveforce);
       

    }
   
    void Rotacion()
    {
        rb.AddTorque(push * torqueforce);
    }
}
