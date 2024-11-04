using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] int vidaHeroi = 100;
    string resultado;

    void Start()
    {
        if (vidaHeroi > 0)
        {
            print("Personagem Vivo");
        }
        else
        {
            print("Game Over");
        }

        // condição ? valor a ser chamado caso verdadeiro : caso falso 
        resultado = (vidaHeroi > 0) ? "Personagem Vivo" : "Game Over!";
        print(resultado);

    }
    private void Update()
    {
        
    }
}
