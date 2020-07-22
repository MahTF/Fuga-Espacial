using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Colocado : IComparable
{
    public string Nome;
    public int Pontos;
    public int Id;

    public Colocado(string nome, int pontos, int id)
    {
        Nome = nome;
        Pontos = pontos;
        Id = id;
    }

    public int CompareTo(object obj)
    {
        var outroObj = obj as Colocado;
        return outroObj.Pontos.CompareTo(Pontos);
    }
}
