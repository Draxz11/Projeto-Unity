using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer01 : MonoBehaviour
{

    //1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "In�cio da partida!" ao final.
    void Start()
    {
        //for(inicializador; condi��o; incremento/decremento)
        for (int i = 5; i > 0; i--)
        {
            print(i);
        }

        print("Inicio da partida");
    }

    void Update()
    {
        
    }
}
