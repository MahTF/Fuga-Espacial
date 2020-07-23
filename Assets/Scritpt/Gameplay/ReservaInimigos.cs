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
            inimigo.SetActive(false);
            reservaInimigos.Push(inimigo);
        }
    }

    public GameObject PegarInimigo()
    {
        return reservaInimigos.Pop();
    }

    public bool PossuiInimigo()
    {
        return reservaInimigos.Count > 0;
    }
}
