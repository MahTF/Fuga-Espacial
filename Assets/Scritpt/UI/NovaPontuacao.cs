using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    private Pontuacao pontuacao;

    private void Start()
    {
        pontuacao = FindObjectOfType<Pontuacao>();
        var totalPontos = -1;
        if (pontuacao != null)
        {
            totalPontos = pontuacao.Pontos;
        }
        textoPontuacao.AtualizarTexto(totalPontos);
    }
}
