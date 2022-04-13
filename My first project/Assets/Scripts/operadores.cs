using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadores : MonoBehaviour
{
    int num1,num2,num3,result;


    void Start()
    {
        num1 = 10;
        num2 = 21;
        num3 = 2;

        result = (num1 + num2) * num3;
        print(result);
    }


    void Update()
    {
        
    }
}
