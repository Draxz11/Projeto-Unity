using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio5 : MonoBehaviour
{

    //5. (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //incompleta".

    [SerializeField] int Pontos = 100;

    void Start()
    {
        if (Pontos > 50)
        {
            print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    void Update()
    {

    }
}
