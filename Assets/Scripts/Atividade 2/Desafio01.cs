using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    //Escreva um programa que conta o número de consoantes em uma string.

    [SerializeField] string texto = "Jogos digitais";
    [SerializeField] int contadorConsoantes;

    void Start()
    {
        //for(inicializador; condição; incremento/decremento)
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(Char.ToLower(letra)) || "bcdfghjklmnpqrstvwxyz".ToUpper().Contains(letra) )
            {
                contadorConsoantes++;
            }
        }

        print("O número de consoantees é: " +  contadorConsoantes); 
    }

    void Update()
    {
        
    }
}
