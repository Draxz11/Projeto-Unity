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

        //Operador tern�rio
        // codi��o ? valor a ser atribuido caso verdadeiro : caso falso 
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

        //estado01: vil�o ataca
        //estado02: vil�o defende
        //estado03: vil�o toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vil�o atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vil�o defende");
                break;

            case 3:
                print("Vil�o tomando um coro");
                break;

            default:
                print("Valor n�o identificado");
                break;  
                

        }

    }
    void Update()
    {

    }
}
