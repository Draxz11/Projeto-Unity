using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    //Escreva um programa que conta o n�mero de consoantes em uma string.

    [SerializeField] string texto = "Jogos digitais";
    [SerializeField] int contadorConsoantes;

    void Start()
    {
        //for(inicializador; condi��o; incremento/decremento)
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(Char.ToLower(letra)) || "bcdfghjklmnpqrstvwxyz".ToUpper().Contains(letra) )
            {
                contadorConsoantes++;
            }
        }

        print("O n�mero de consoantees �: " +  contadorConsoantes); 
    }

    void Update()
    {
        
    }
}
