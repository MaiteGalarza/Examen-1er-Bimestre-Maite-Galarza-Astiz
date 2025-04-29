using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoDeServicio;
    public int cantidadDeHoras;

    int precioTotal;
    int precioConDescuento;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeHoras > 6 || (tipoDeServicio != "F" && tipoDeServicio != "C" && tipoDeServicio != "R"))
        {
            Debug.Log("Cantidad de horas no valida o código incorrecto");
            return;
        }  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
