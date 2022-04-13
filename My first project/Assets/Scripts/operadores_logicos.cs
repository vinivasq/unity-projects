using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadores_logicos : MonoBehaviour
{

    int num1 = 10;
    int num2 = 20;

    /*
        AND = &&
        OR = ||
        NOT = !()
    */
    void Start()
    {
        // o and não ta exemplificado mas deu pra entender né, mesma funcionalidade das portas logicas 
        print ("Operador OR");

        print  (num1 != num2 || num1 != num2); // true
        print  (num1 != num2 || num1 == num2);  // true
        print  (num1 == num2 || num1 != num2); // true
        print  (num1 == num2 || num1 == num2);  // false

        print ("Operador Not");

        print (!(num1 == num2)); // true
        print (!(num1 != num2)); // false
        

    }

    void Update()
    {
        
    }
}
