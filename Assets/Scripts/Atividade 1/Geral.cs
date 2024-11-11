using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    //int vidaJogador = 10;

    //float velocidadeCarro = 125.5f;

    //string nomeJogador = "Mister";

    //char apelido = 'M';

    //bool vivo = true;

    //== (igual)
    //!= (diferente)
    //>  (Maior que)
    //<  (Menor que)
    //<= (Menor igual)
    //>= (Maior igual)


    //[SerializeField] int vidaHeroi = 100;
    //[SerializeField] int vidaVilao = 300;
    //string resultado;

    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        //print(vidaVilao == vidaHeroi); //false
        //print(vidaHeroi <= vidaVilao); //true
        //print(vidaVilao != vidaHeroi); //true

        //Operador ternário
        // codição ? valor a ser atribuido caso verdadeiro : caso falso 
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior" ;

        //print(resultado);

        //Estrutura condicional
        //if (vidaheroi < vidavilao)
        //{
        //    resultado = "vida heroi menor";
        //    print(resultado);

        //}
        //else if (vidaheroi == vidavilao)
        //{

        //    resultado = "vida heroi maior";
        //    print(resultado);




        //}

        //estado01: vilão ataca
        //estado02: vilão defende
        //estado03: vilão toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vilão atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vilão defende");
                break;

            case 3:
                print("Vilão tomando um coro");
                break;

            default:
                print("Valor não identificado");
                break;  
                

        }

    }
    void Update()
    {

    }
}
