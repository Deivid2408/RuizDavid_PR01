using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorEscenas : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void CargarEscene(int escena)
    {
        SceneManager.LoadScene(escena);
    }

  


    
}
