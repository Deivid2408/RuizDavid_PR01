using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanoReset : MonoBehaviour
{

    private Vector3 spawn;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = transform.position;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Perder();
    }

    void Perder()
    {
        if (transform.position.y < -30)
        {
            transform.position = spawn;

            //Detener la velocidad del objeto al resetear su posicion y no acumule velocidad
            rb.Sleep();

        }

    }

}
