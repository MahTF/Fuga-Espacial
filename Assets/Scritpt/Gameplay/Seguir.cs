using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    [SerializeField]
    private float Velocidade;
    private Transform alvo;

    private void Update()
    {
        var deslocamento = alvo.position - transform.position;
        deslocamento = deslocamento.normalized;

        deslocamento *= Velocidade;

        transform.position += deslocamento * Time.deltaTime;
    }

    public void SetAlvo(Transform novoAlvo)
    {
        alvo = novoAlvo;
    }
}
