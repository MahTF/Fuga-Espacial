using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    [SerializeField]
    private float forca;
    private Transform alvo;
    private Rigidbody2D fisica;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var deslocamento = alvo.position - transform.position;
        deslocamento = deslocamento.normalized;
        deslocamento *= forca;

        fisica.AddForce(deslocamento, ForceMode2D.Force);
    }

    public void SetAlvo(Transform novoAlvo)
    {
        alvo = novoAlvo;
    }
}
