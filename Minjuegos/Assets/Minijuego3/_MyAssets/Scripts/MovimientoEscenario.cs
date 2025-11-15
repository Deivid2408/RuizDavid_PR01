using UnityEngine;

public class MovimientoEscenario : MonoBehaviour
{
    Rigidbody rb;
    float rotX;
    float rotZ;
    float torqueforce = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        rotX = Input.GetAxis("Rotation2");

        rotZ = Input.GetAxis("Vertical2");

        Vector3 push = new Vector3(0, 0, rotZ);
        Vector3 rotation = new Vector3(rotX, 0, 0);
        rb.AddTorque(push * torqueforce);
        rb.AddTorque(rotation * torqueforce);
    }
}
