using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReservaInimigos : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabInimigo;
    [SerializeField]
    private int quantidade;
    private Stack<GameObject> reservaInimigos;
    private void Start()
    {
        reservaInimigos = new Stack<GameObject>();
        CriarTodosInimigos();
    }

    private void CriarTodosInimigos()
    {
        for (int i = 0; i <= quantidade; i++)
        {
            var inimigo = Instantiate(prefabInimigo, transform);
            var objetoReserva = inimigo.GetComponent<ObjetoReservaInimigos>();
            objetoReserva.SetReserva(this);
            inimigo.SetActive(false);
            reservaInimigos.Push(inimigo);
        }
    }

    public GameObject PegarInimigo()
    {
        var inimigo = reservaInimigos.Pop();
        inimigo.SetActive(true);
        return inimigo;
    }

    public bool PossuiInimigo()
    {
        return reservaInimigos.Count > 0;
    }

    public void ReciclarInimigo(GameObject inimigo)
    {
        inimigo.SetActive(false);
        reservaInimigos.Push(inimigo);
    }
}
