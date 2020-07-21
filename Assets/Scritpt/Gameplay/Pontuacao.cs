using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    public int Pontos {
        get
        {
            return pontos;
        }
    }
    [SerializeField]
    private MeuEventoPersonalizadoInt aoPontuar;
    private int pontos;

    public void Pontuar()
    {
        pontos++;
        aoPontuar.Invoke(pontos);
    }
}