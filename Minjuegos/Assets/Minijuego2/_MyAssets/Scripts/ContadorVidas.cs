using TMPro;
using UnityEngine;

public class ContadorVidas : MonoBehaviour
{
    public int vidas = 4;
    public int aciertos = 0;

    public TMP_Text textoVidas;
    public TMP_Text textoAciertos;

    void Start()
    {

        ActualizarTexto();
        print("Vidas iniciales: " + vidas);
    }


    public void ActualizarTexto()
    {
        textoVidas.text = "Vidas: " + vidas;
        textoAciertos.text = "Aciertos: " + aciertos;
    }
    

    public void ContadorAciertos()
    {
        aciertos++;
        print("Has acertado! Aciertos totales: " + aciertos);
        ActualizarTexto();

    }


    public void PerderVida()
    {
        vidas--;
        print("Has perdido una vida. Vidas restantes: " + vidas);
        ActualizarTexto();

        if (vidas <= 0)
        {
            print("Has perdido");
        }
    }
}