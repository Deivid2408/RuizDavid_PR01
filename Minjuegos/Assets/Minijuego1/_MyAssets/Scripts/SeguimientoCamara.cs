using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] Transform player;

   

    //Distance está calculando en qué posición se va a poner la cámara
    public Vector3 distance = new Vector3(0,0,0);

    //Y rotación en qué ángulo va a estar rotada la cámara
    public Vector3 rotacion = new Vector3(0,0,0);

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Seguimiento();

        //Y con esto le estoy diciendo que cambie de posición a donde está el objeto y le reste la distancia a la que está del objeto. Es decir, que va a ponerse detrás del objeto (bola).
        //transform.position = player.position - distance;

        //Aquí le estoy diciendo que cambie la posición de la cámara a la posición del player.
        //transform.LookAt(player.position);

    }

    void Seguimiento()
    {
        transform.position = player.position - distance;

        transform.LookAt(player.position);
    }
}
