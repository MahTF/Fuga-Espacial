using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    [SerializeField]
    private TextoDinamico textoNome;
    [SerializeField]
    private Ranking ranking;
    private Pontuacao pontuacao;
    private string id;

    private void Start()
    {
        int totalPontos = GetPontuacao();
        var nomePessoa = GetNome();
        textoPontuacao.AtualizarTexto(totalPontos);
        textoNome.AtualizarTexto(nomePessoa);
        id = ranking.AdicionarPontuacao(totalPontos, nomePessoa);
    }

    private int GetPontuacao()
    {
        pontuacao = FindObjectOfType<Pontuacao>();
        var totalPontos = -1;
        if (pontuacao != null)
        {
            totalPontos = pontuacao.Pontos;
        }
        return totalPontos;
    }

    private string GetNome()
    {
        if (PlayerPrefs.HasKey("UltimoNome"))
        {
            return PlayerPrefs.GetString("UltimoNome");
        }
        return "Nome";
    }

    public void AlterarNome(string nome)
    {
        ranking.AlterarNome(nome, id);
        PlayerPrefs.SetString("UltimoNome", nome);
    }

}
