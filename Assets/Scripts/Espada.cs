using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Espada
public class Espada : Arma, IMejorable, IHabilidadEspecial
{
    public Espada(string nombre, int daño) : base(nombre, daño) { }

    public override void Usar()
    {
        base.Usar();
        Debug.Log("Ataque activado!!!!");
    }

    public void Mejorar()
    {
        IncrementarDaño(12);
        Debug.Log(Nombre + " mejorada. Nuevo daño: " + Daño);
    }
    public void ActivarHabilidad()
    {
        Debug.Log(Nombre + " ha activado Corte doble!!!");
    }

}
#endregion

