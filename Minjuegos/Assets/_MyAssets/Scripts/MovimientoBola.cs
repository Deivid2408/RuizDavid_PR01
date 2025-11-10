using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public class MovimientoBola : MonoBehaviour
{
    Rigidbody rb;
    

    float moveforce = 10f;
    float torqueforce = 5f;

    float moveZ;
    float moveX;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");



       Vector3 direction = new Vector3(moveX, 0, moveZ);
       rb.AddForce(direction * moveforce);
       rb.AddTorque(direction * torqueforce);


    }
   
   
}
