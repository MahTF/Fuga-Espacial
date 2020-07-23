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
    private Rect area;
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
        var posicaoAleatoria = new Vector2(Random.Range(area.x, area.x + area.width),
                                            Random.Range(area.y, area.y + area.height));

        var posicaoInimigo = (Vector2)transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(100, 0, 100);
        var posicao = area.position + (Vector2)transform.position + area.size / 2;
        Gizmos.DrawWireCube(posicao, area.size);
    }
}
