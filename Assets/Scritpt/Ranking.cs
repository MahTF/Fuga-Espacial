using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;

    private void Start()
    {
        pontos = new List<int>();
    }

    public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        SalvarRanking();
    }

    private void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this);
        var caminhoArquivo = Path.Combine(Application.persistentDataPath, NOME_ARQUIVO);
        File.WriteAllText(caminhoArquivo, textoJson);
    }
}
