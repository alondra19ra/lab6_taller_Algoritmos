using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMejorable
{
    void Mejorar();
}
public interface IHabilidadEspecial
{
    void ActivarHabilidad();
}
#region 
public class Arma 
{
    #region private
    private string nombre;
    private int daño;
    #endregion

    #region Getters
    public string Nombre => nombre;
    public int Daño => daño;
    #endregion

    #region Constructor
    public Arma(string nombre, int daño)
    {
        this.nombre = nombre;
        this.daño = daño;
    }
    #endregion

    #region Métodos
    public virtual void Usar()
    {
        Debug.Log(nombre + " usada. Daño base: " + daño);
    }

    protected void IncrementarDaño(int cantidad)
    {
        daño += cantidad;
    }
    #endregion
}


#endregion
