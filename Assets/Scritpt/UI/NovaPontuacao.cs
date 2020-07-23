using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    [SerializeField]
    private Ranking ranking;
    private Pontuacao pontuacao;
    private string id;

    private void Start()
    {
        pontuacao = FindObjectOfType<Pontuacao>();
        var totalPontos = -1;
        if (pontuacao != null)
        {
            totalPontos = pontuacao.Pontos;
        }
        textoPontuacao.AtualizarTexto(totalPontos);
        id = ranking.AdicionarPontuacao(totalPontos, "Nome");
    }

    public void AlterarNome(string nome)
    {
        ranking.AlterarNome(nome, id);
    }
}
