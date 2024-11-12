using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer02 : MonoBehaviour
{
    /*(Multiplicação de dano) Um personagem ataca cinco vezes, e o
    dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
    ataque.*/

    [SerializeField] int dano = 10;
    void Start()
    {
        //for(inicializa; condição; incremento/decremento)
        for (int i = 0; i <= 5; i++) 
        {
            print("Ataque" + i + ": Dano " + dano);
            //dano = dano + 2;
            dano += 2;
        }
    }

    void Update()
    {
        
    }
}
