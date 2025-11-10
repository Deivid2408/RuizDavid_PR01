using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.LookAt(player.transform);

        transform.position = player.transform.position - offset;
    }
}
