using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public string codigo_gusto;
    public float gramos;
    // Start is called before the first frame update
    void Start()
    {
        float costo_pedido;

        if (gramos < 250 || gramos > 3000)
        {
            Debug.Log("Error. Ingrese otra cantidad de helado");
        }
        else
        {
            switch (codigo_gusto)
            {
                case "CHO":
                    costo_pedido = gramos * 500 / 1000;
                    Debug.Log("El costo de su pedido es de $" + costo_pedido);
                    break;
                case "FRU":
                    costo_pedido = gramos * 500 / 1000 * 90 / 100;
                    Debug.Log("El costo de su pedido es de $" + costo_pedido);
                    break;

                case "DDL":
                    costo_pedido = gramos * 500 / 1000;
                    Debug.Log("El costo de su pedido es de $" + costo_pedido);
                    break;
                default:
                    Debug.Log("Error. Código no válido");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
