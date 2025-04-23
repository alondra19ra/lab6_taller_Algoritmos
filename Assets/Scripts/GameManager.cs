using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Espada espada = new Espada("Espada ", 30);
        Arco arco = new Arco("Arco", 20);

        espada.Usar();
        espada.Mejorar();
        espada.ActivarHabilidad();
     

        Debug.Log(" ");

        arco.Usar();
        arco.Mejorar();
        arco.ActivarHabilidad();
    }
}
