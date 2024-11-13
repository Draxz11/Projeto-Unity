using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer07 : MonoBehaviour
{
    //    7. (Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.
    
   
    int[] numeros = { 3, 5, 45, 7, 10, 68, 23, 71, 18, 97};
    int maior;

    void Start()
    {
        foreach (var item in numeros) 
        {
            if (maior == 0) 
                maior = item;

            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior número é: " + maior);
    }

    void Update()
    {
        
    }
}
