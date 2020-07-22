using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelRanking : MonoBehaviour
{
    [SerializeField]
    private Ranking ranking;
    [SerializeField]
    private GameObject prefabColocado;

    private void Start()
    {
        var listaColocados = ranking.GetColocados();
        for (int i = 0; i < listaColocados.Count; i++)
        {
            if (i >= 5)
            {
                break;
            }

            var colocado = Instantiate(prefabColocado, transform);
            colocado.GetComponent<ItemRanking>().Configurar(i + 1, listaColocados[i].Nome, listaColocados[i].Pontos);
        }
    }
}
