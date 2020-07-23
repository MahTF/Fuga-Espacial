using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoReservaInimigos : MonoBehaviour
{
    private ReservaInimigos reserva;

    public void ReciclarInimigo()
    {
        reserva.ReciclarInimigo(gameObject);
    }

    public void SetReserva(ReservaInimigos reserva)
    {
        this.reserva = reserva;
    }
}
