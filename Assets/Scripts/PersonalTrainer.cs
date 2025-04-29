using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoDeServicio;
    public int cantidadDeHoras;

    int precioTotal;
    float precioConDescuento;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeHoras > 6 || (tipoDeServicio != "F" && tipoDeServicio != "C" && tipoDeServicio != "R"))
        {
            Debug.Log("Cantidad de horas no valida o código incorrecto");
            return;
        }  
        if (tipoDeServicio == "C")
        {
            precioTotal = cantidadDeHoras * 1000;
        } else if (tipoDeServicio == "F")
        {
            precioTotal = cantidadDeHoras * 1500;
        } else
        {
            precioTotal = cantidadDeHoras * 2500;
        }
        if (cantidadDeHoras == 6)
        {
            precioConDescuento = precioTotal * 0.9f;
        }
        Debug.Log("Tipo de entrenamiento: " + tipoDeServicio + " - Cantidad de horas reservadas: " + cantidadDeHoras + 
            "h - Precio sin descuento: $" + precioTotal + " - Precio con descuento: $" + precioConDescuento );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
