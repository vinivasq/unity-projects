using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchestados : MonoBehaviour
{
    // Estados do inimigo
    // status 1: coragem
    // status 2: calmo
    // status 3: covarde

    int status = 1;

    void Start()
    {
        switch (status)
        {
            default:
                print ("Nenhum estado disponível");
                break;
            case 1:
                print ("Avance no heroi");
                break;
            case 2:
                print ("Mate se puder");
                break;
            case 3:
                print ("Fuja e se proteja!");
                break;
        }
    }

    void Update()
    {
        
    }
}
