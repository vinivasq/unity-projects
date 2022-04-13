using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    // assim que se faz comentario aqui, muito melhor pqp
    /* também da pra comentar assim
    daí pode comentar em outras linhas que nem no html
    */

    int moedas = 10;
    float dinheiro = 1118.25f;
    bool rico = false;
    string ditado = "Não ta morto quem peleia";

    void Start()
    {   
        print (moedas);
        print (dinheiro);
        print (rico);
        print (ditado);

        //conversão de dados

        moedas = (int)dinheiro;
        ditado = dinheiro.ToString();

    }

    void Update()
    {
        
    }
}


