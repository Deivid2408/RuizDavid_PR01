using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour

{
    [SerializeField] TMP_Text timer;
    int cronometro = 61;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cronometro--;
        timer.text = cronometro.ToString("Segundos" + cronometro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
