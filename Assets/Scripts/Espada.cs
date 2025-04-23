using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Espada
public class Espada : Arma, IMejorable, IHabilidadEspecial
{
    public Espada(string nombre, int da�o) : base(nombre, da�o) { }

    public override void Usar()
    {
        base.Usar();
        Debug.Log("Ataque activado!!!!");
    }

    public void Mejorar()
    {
        IncrementarDa�o(12);
        Debug.Log(Nombre + " mejorada. Nuevo da�o: " + Da�o);
    }
    public void ActivarHabilidad()
    {
        Debug.Log(Nombre + " ha activado Corte doble!!!");
    }

}
#endregion

