

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HolaMundo();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            EscribirCadena("Mi cadena es esta:");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Concatenador("mensaje" , 10);
        }

    }
    //Funciones:

    //Definir una función que escriba en consola “Hola Mundo!” al ser invocada.
    //Invocar la función al presionar la barra espaciadora.

    void HolaMundo()
    {
        Debug.Log("Hola mundo!");
    }

    ////Definir una función que escriba en consola la cadena pasada por parámetro.

    void EscribirCadena(string cadena)
    {
        Debug.Log(cadena);
    }

    //Definir una función que concatene y muestre en consola un string y un int pasados por parámetros. 

    void Concatenador(string text, int num)
    {
        string msg = text + num;
        Debug.Log(msg);
    }


}
