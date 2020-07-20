using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private MeuEventoPersonalizadoInt aoPontuar;
    private int pontos;

    public void Pontuar()
    {
        pontos++;
        aoPontuar.Invoke(pontos);
    }
}

[Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>
{

}