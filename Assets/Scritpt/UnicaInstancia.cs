using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
    private void Start()
    {
        var outrasInstancias = GameObject.FindGameObjectsWithTag(tag);
        foreach (var instancia in outrasInstancias)
        {
            if(instancia != this.gameObject)
            {
                Destroy(instancia.gameObject);
            }
        }
    }
}
