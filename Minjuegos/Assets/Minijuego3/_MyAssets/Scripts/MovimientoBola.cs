using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float fuerzaEmpuje;
    [SerializeField] float fuerzaTorsion;

    Vector3 empujeZ = Vector3.forward;
    Vector3 empujeX = Vector3.right;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaTorsion = 0f;
        fuerzaEmpuje = 9.5f;

        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Rotacion();
        Empuje();
    }
    void Empuje()
    {

        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        rb.AddForce(empujeZ * moveZ * fuerzaEmpuje);
        rb.AddForce(empujeX * moveX * fuerzaEmpuje);
    }
    void Rotacion()
    {

        float rotacion = Input.GetAxis("Horizontal2");
        rb.AddTorque(Vector3.forward * rotacion * fuerzaTorsion);
        rb.AddTorque(Vector3.right * rotacion * fuerzaTorsion);
    }


}