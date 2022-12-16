using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Marcadores : MonoBehaviour
{

    public static Marcadores instance;

    [SerializeField]
    TextMeshProUGUI resultadoJugadorUno, resultadoJugadorDos;

    int golesJugador1, golesJugador2;

    private void Awake()
    {
        
        if (Marcadores.instance == null)
        {
            Marcadores.instance = this;

        }
        else
        {

            Destroy(this);

        }

    }

    void Start()
    {
        golesJugador1 = 0;
        golesJugador2 = 0;

    }

    public void GolJugador1()
    {
        golesJugador1++;

        resultadoJugadorUno.text = golesJugador1.ToString();
    }




    public void GolJugador2()
    {
        golesJugador2++;

        resultadoJugadorDos.text = golesJugador2.ToString();
    }
}
