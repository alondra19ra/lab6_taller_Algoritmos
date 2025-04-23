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
    private int da�o;
    #endregion

    #region Getters
    public string Nombre => nombre;
    public int Da�o => da�o;
    #endregion

    #region Constructor
    public Arma(string nombre, int da�o)
    {
        this.nombre = nombre;
        this.da�o = da�o;
    }
    #endregion

    #region M�todos
    public virtual void Usar()
    {
        Debug.Log(nombre + " usada. Da�o base: " + da�o);
    }

    protected void IncrementarDa�o(int cantidad)
    {
        da�o += cantidad;
    }
    #endregion
}


#endregion
