using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CocheClass
{
    public string marca;

    //Creamos los objetos
    public Ruedas ruedas = new Ruedas();
    public Puerta puerta = new Puerta();
    public void EncenderMotor()
    {
        Debug.Log("Motor encendido");
        Debug.Log(marca);
        
    }

    public void ApagarMotor()
    {
        Debug.Log("Motor apagado");
    }
}