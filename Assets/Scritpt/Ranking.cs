using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;
    private string caminhoArquivo;

    private void Awake()
    {
        caminhoArquivo = Path.Combine(Application.persistentDataPath, NOME_ARQUIVO);
        var textoJson = File.ReadAllText(caminhoArquivo);
        JsonUtility.FromJsonOverwrite(textoJson, this);
    }

    public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        SalvarRanking();
    }

    private void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this);
        File.WriteAllText(caminhoArquivo, textoJson);
    }

    public ReadOnlyCollection<int> GetPontos()
    {
        return pontos.AsReadOnly();
    }
}
