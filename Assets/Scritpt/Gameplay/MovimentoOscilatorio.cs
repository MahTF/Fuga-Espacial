using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoOscilatorio : MonoBehaviour
{
    [SerializeField]
    private float amplitude;
    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float angulo;

    private void Awake()
    {
        posicaoInicial = transform.position;
    }
    private void Update()
    {
        angulo += velocidade;
        var variacao = Mathf.Sin(angulo);
        transform.position = posicaoInicial + (amplitude * variacao * Vector3.up); ;
    }
}
