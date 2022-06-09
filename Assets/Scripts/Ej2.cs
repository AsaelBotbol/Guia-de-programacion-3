using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    //Variables:
    public GameObject miObj;
    public GameObject otroObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PosicionarObj(miObj);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (PosicionYNoNegativa(otroObj) == true)
            {
                Debug.Log("'Y' no es negativa");
            }
            else
            {
                Debug.Log("'Y' es negativa");
            }
        }

    }
    //Funciones:

    //Recibe como parámetro un objeto y lo posiciona en el origen del espacio.
    void PosicionarObj(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }

    //Devuelve true si el valor de Y de la posición de un GameObject...
    //recibido como parámetro no es negativo, false si lo es.
    bool PosicionYNoNegativa(GameObject obj)
    {
        bool yNoNegativa = false;

        if(obj.transform.position.y >= 0)
        {
            yNoNegativa = true;
        }

        return yNoNegativa;
    }
}
