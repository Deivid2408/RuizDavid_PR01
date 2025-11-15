using UnityEngine;

public class MovimientoCesto : MonoBehaviour
{

    float velocidad = 15f;
    float limiteDerecha = 28f;
    float limiteIzquierda = -28f;

    public ContadorVidas contadorVidas;

    //1 = derecha, -1 = izquierda
    float direccion = 1f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Referencia al script ContadorVidas. Es decir, que busque el script en la escena.
        contadorVidas = FindAnyObjectByType<ContadorVidas>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Esto moverá la plataforma según la dirección
        transform.Translate(Vector3.right * direccion * velocidad * Time.deltaTime);

        if (transform.position.x >= limiteDerecha)
        {
            //Cambia dirección a izquierda
            direccion = -1f; 
        }
        else if(transform.position.x <= limiteIzquierda)
        {
            //Cambia dirección a derecha
            direccion = 1f; 
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bola"))
        {
            print("Has ganado");
            Acierto();

        }
        
    }

    public void Acierto()
    {
        contadorVidas.ContadorAciertos();

    }

}
