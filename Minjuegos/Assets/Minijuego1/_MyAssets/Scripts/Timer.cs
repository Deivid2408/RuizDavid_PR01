using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    [SerializeField] TMP_Text timer;
    int cronometro = 61;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer.text = cronometro + "segundos";

        Countdown();
        Perder();
    }

    void Countdown()
    {
        cronometro--;
        timer.text = cronometro + " segundos";
        
        if (cronometro <= 0)
        {
            Perder();
            timer.text = "0 segundos";
            return;
        }

        //Esto sirve para se ejecute cada segundo
        Invoke("Countdown", 1f);



    }

    void Perder()
    {
        if (cronometro <= 0)
        {
            print ("GameOver");

            SceneManager.LoadScene(1);


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
