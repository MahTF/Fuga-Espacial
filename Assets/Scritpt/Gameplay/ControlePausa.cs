using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePausa : MonoBehaviour
{
    [SerializeField]
    private GameObject painelPause;
    [SerializeField, Range(0, 1)]
    private float escalaTempoPause;
    private bool jogoParado;
    private void Update()
    {
        if (TocandoTela())
        {
            if (jogoParado)
            {
                ContinuarJogo();
            }
        }
        else
        {
            if (!jogoParado)
            {
                PararJogo();
            }
        }
    }

    private bool TocandoTela()
    {
        return Input.touchCount > 0;
    }

    private void ContinuarJogo()
    {
        StartCoroutine(EsperarEContinuar());
    }

    private IEnumerator EsperarEContinuar()
    {
        yield return new WaitForSecondsRealtime(0.2F);
        painelPause.SetActive(false);
        MudarEscalaTempo(1);
        jogoParado = true;
    }

    private void PararJogo()
    {
        painelPause.SetActive(true);
        MudarEscalaTempo(escalaTempoPause);
        jogoParado = false;
    }

    private void MudarEscalaTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = 0.02F * escala;
    }
}
