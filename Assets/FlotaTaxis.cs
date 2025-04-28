using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaTaxis : MonoBehaviour
{
    public int cantidadTaxis;
    public int cantidadDias;
    int taxisKM;
    int KMporDia = 90;
    int KMporL = 15;
    int precioPorL = 130;
    int KMtotal;
    int Ltotal;
    int precioTotal;
    int precioDescuento;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDias < 5)
        {
            Debug.Log("ERROR: La cantidad de dias debe ser mayor que 5");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
