using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio6 : MonoBehaviour
{

    //6. (Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    [SerializeField] bool Guerreiro; //true

    void Start()
    {
        if (Guerreiro == true)
        {
            print("Guerreiro Escolhido");
        }
        else
        {
            print("Mago Escolhido");
        }
    }

    void Update()
    {

    }
}
