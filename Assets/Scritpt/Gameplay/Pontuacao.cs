using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int pontos;

    public void Pontuar()
    {
        pontos++;
        AtualizarPontuacao();
    }

    private void AtualizarPontuacao()
    {
        textoPontuacao.text = pontos.ToString();
    }
}
