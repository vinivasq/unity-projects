using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicionais : MonoBehaviour
{
    int moedas = 120;
    int item = 100;
    string result;

    void Start()
    {
        /*
        if (moedas == item)  // poderia usar um >= porém separei para exemplificar o else-if
        {
            print ("Item adquirido!"); 
        }   

        else if (moedas > item) {
            print ("Item adquirido e ainda sobrou uma merreca");
        }

        else
        {
            print ("Moedas insuficientes");
        }
        */
        
        // Operadores ternarios
        // CONDIÇÃO?TRUE:FALSE

        result = (moedas >= item)?"Item adquirido!":"Moedas insuficientes";
        print (result);
    }

    void Update()
    {
        
    }
}
