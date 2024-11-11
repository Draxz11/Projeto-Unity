using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{

    //3. (Desafio) Considere que o jogo tem um power-up que revive o
    //    personagem caso ele morra.Caso o jogador morra e tiver
    //    coletado o power-up ele volta a vida com 50% de sua vida total e
    //    deve ser exibido a mensagem "Ainda não, vida atual XX". Caso ele
    //    não tenha coletado o power-up exiba "Game Over".

    //Operadores Lógicos
    // && (E / AND)
    // ! (NÃO / NOT)
    // || (OU / OR)

    [SerializeField] bool PlayerVivo;//true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    int vidaPlayerInicial = 100;
    double vidaPlayerAtual = 100;

    void Start()
    {
        //    if (playervivo == false && powerup == true)
        //    {
        //        vidaplayer = vidaplayer * 0.5;
        //        print("ainda não, vida atual" + vidaplayer);
        //    }
        //}

        //void update()
        //{
        //    print("game over");


        if (vidaPlayerAtual <= 0 && powerUp == true)
        {
            vidaPlayerAtual = vidaPlayerInicial * 0.5;
            print("Ainda não, vida atual" + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }

    }
}