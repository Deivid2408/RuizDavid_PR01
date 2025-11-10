using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform player;
    public Vector3 distancia = new Vector3(0, 0, -20);
    public Vector3 rotacion = new Vector3 (0, 0, 0);
    float rotspeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
        Rot();
    }

    void Follow()
    {
        transform.position = player.position - distancia;
        transform.LookAt(player.position);
    }
    
    void Rot()
    {
        transform.RotateAround(player.position, Vector3.right, rotspeed * Time.deltaTime);
    }
}
