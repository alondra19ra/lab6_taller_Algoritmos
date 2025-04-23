using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Arco
public class Arco : Arma, IMejorable, IHabilidadEspecial
{
    public Arco(string nombre, int da�o) : base(nombre, da�o) { }

    public override void Usar()
    {
        base.Usar();
        Debug.Log("Flecha disparada!!!");
    }

    public void Mejorar()
    {
        IncrementarDa�o(7);
        Debug.Log(Nombre + " mejorada. Nuevo da�o: " + Da�o);
    }
    public void ActivarHabilidad()
    {
        Debug.Log(Nombre + " ha activado Lluvia de Flechas!!!!");
    }

}
#endregion

