using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private Pontuacao pontuacao;
    [SerializeField]
    private float tempo;
    [SerializeField]
    private float raio;
    [SerializeField]
    private ReservaInimigos reserva;

    private void Start()
    {
        InvokeRepeating("Instanciar", 0f, tempo);
    }

    private void Instanciar()
    {
        if (reserva.PossuiInimigo())
        {
            var inimigo = reserva.PegarInimigo();
            DefinirPosicaoInimigo(inimigo);
            inimigo.GetComponent<Seguir>().SetAlvo(alvo);
            inimigo.GetComponent<Pontuavel>().SetPontuacao(pontuacao);
        }
    }

    private void DefinirPosicaoInimigo(GameObject inimigo)
    {
        var posicaoAleatoria = new Vector3(
                        Random.Range(-raio, raio),
                        Random.Range(-raio, raio),
                        0);

        var posicaoInimigo = transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }
}
