using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<Colocado> listaColocados;
    private string caminhoArquivo;

    private void Awake()
    {
        caminhoArquivo = Path.Combine(Application.persistentDataPath, NOME_ARQUIVO);
        if (File.Exists(caminhoArquivo))
        {
            var textoJson = File.ReadAllText(caminhoArquivo);
            JsonUtility.FromJsonOverwrite(textoJson, this);
        }
        else
        {
            listaColocados = new List<Colocado>();
        }
    }

    public int AdicionarPontuacao(int pontos, string nome)
    {
        var id = listaColocados.Count * Random.Range(1, 10000);
        var novoColocado = new Colocado(nome, pontos, id);
        listaColocados.Add(novoColocado);
        listaColocados.Sort();
        SalvarRanking();
        return id;
    }

    private void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this);
        File.WriteAllText(caminhoArquivo, textoJson);
    }

    public ReadOnlyCollection<Colocado> GetColocados()
    {
        return listaColocados.AsReadOnly();
    }

    public void AlterarNome(string novoNome, int id)
    {
        foreach(var item in listaColocados)
        {
            if(item.Id == id)
            {
                item.Nome = novoNome.Trim();
                break;
            }
        }
        SalvarRanking();
    }
}
