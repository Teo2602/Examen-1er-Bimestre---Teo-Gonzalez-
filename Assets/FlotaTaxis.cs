using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaTaxis : MonoBehaviour
{
    public int cantidadTaxis;
    public int cantidadDias;
    int KMporDia = 90;
    int LporKM = 15;
    int precioPorL = 130;
    int KMtotal;
    float Ltotal;
    float precioTotal;
    float cantidadDescuento;
    float precioFinal;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDias < 5)
        {
            Debug.Log("ERROR: La cantidad de dias debe ser mayor o igual que 5");
            return;
        }
        if (cantidadTaxis < 1)
        {
            Debug.Log("ERROR: La cantidad de dias debe ser mayor o igual que 1");
            return;
        }
        KMtotal = KMporDia * cantidadDias * cantidadTaxis;
        Ltotal = KMtotal / LporKM;
        precioTotal = Ltotal * precioPorL;
        Debug.Log("Una flota de " + cantidadTaxis + " unidades trabajando durante " + cantidadDias + " días implicará un gasto de " + precioTotal + " pesos en concepto de combustible.");
        if (Ltotal >= 100)
        {
            cantidadDescuento = (precioTotal / 100) * 20;
            precioFinal = precioTotal - cantidadDescuento;
            Debug.Log("La cantidad de descuento aplicado por sobrepasar los 100L es de "+cantidadDescuento+" pesos siendo el precio final de "+precioFinal+" pesos.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
