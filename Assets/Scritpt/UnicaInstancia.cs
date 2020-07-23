using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
    [SerializeField]
    private bool sobreescreverExistente;
    private void Start()
    {
        var outrasInstancias = GameObject.FindGameObjectsWithTag(tag);
        foreach (var instancia in outrasInstancias)
        {
            if(instancia != this.gameObject)
            {
                if (sobreescreverExistente)
                {
                    Destroy(instancia.gameObject);
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
