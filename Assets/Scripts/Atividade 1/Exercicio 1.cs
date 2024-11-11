using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{

        //1. (Verifica��o de pontos de vida) Um personagem perde pontos
        //de vida ap�s uma batalha.Verifique se ele ainda est� vivo.Caso
        //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
        //contr�rio, "Game Over".

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

        // condi��o ? valor a ser chamado caso verdadeiro : caso falso 
        resultado = (vidaHeroi > 0) ? "Personagem Vivo" : "Game Over!";
        print(resultado);

    }
    private void Update()
    {
        
    }
}
