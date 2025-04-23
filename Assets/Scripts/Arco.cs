using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Arco
public class Arco : Arma, IMejorable, IHabilidadEspecial
{
    public Arco(string nombre, int daño) : base(nombre, daño) { }

    public override void Usar()
    {
        base.Usar();
        Debug.Log("Flecha disparada!!!");
    }

    public void Mejorar()
    {
        IncrementarDaño(7);
        Debug.Log(Nombre + " mejorada. Nuevo daño: " + Daño);
    }
    public void ActivarHabilidad()
    {
        Debug.Log(Nombre + " ha activado Lluvia de Flechas!!!!");
    }

}
#endregion

