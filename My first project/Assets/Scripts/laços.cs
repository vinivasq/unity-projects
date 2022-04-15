using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laços : MonoBehaviour
{
    int x;
    //string[] enemies;

    void Start()
    {
        
        for (x = 0; x <= 10; x++)
        {
            print (x);
            if (x == 4)
            {
                continue;
            }
            print(x);
        }
        

        /*
        while (x <= 10)
        {
            print (x);
            x++;
        }
        */
        
        /*
        do
        {
            print (x);
            x++;
            print (x);
        } while (x <= 10);
        */        

        /*
        enemies = new string [4];
        enemies[0] = "mage";
        enemies[1] = "shooter";
        enemies[2] = "warrior";
        enemies[3] = "berseker";

        foreach (string classes in enemies)
        {
            print(classes); 
            if (classes == "warrior")
            {
                break;
            }
        }
        */


    }

    void Update()
    {
        
    }
}
