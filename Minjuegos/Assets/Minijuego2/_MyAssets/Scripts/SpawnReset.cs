using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnReset : MonoBehaviour
{

    private Vector3 spawn;

    Rigidbody rb;
    public ContadorVidas contadorVidas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = transform.position;
        rb = GetComponent<Rigidbody>();
        contadorVidas = FindAnyObjectByType<ContadorVidas>();

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
            rb.Sleep();

        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fallo"))
        {
            print("Has fallado");
            Fallo();


        }

    }


    public void Fallo()
    {
        contadorVidas.PerderVida();
    }
}
