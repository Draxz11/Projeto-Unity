using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{

    //4. (Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    [SerializeField] bool PoçãodeVida; //true

    void Start()
    {
        if (PoçãodeVida == true)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção de vida indisponível");
        }

        print(PoçãodeVida ? "Usando Poção de vida" : "Poção de vida indisponível");
    }

    void Update()
    {

    }
}
