using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{

    //4. (Verificar item de invent�rio) Um jogador possui itens limitados
    //no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
    //Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    //indispon�vel".

    [SerializeField] bool Po��odeVida; //true

    void Start()
    {
        if (Po��odeVida == true)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o de vida indispon�vel");
        }

        print(Po��odeVida ? "Usando Po��o de vida" : "Po��o de vida indispon�vel");
    }

    void Update()
    {

    }
}
