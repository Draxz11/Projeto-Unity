using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer03 : MonoBehaviour
{
    /*(C�lculo de moedas coletadas) O jogador coleta 3 moedas a
   cada fase. Ap�s 10 fases, exiba o total de moedas coletadas.*/

    [SerializeField] int totalMoeda = 0;
    void Start()
    {
        for (int fase = 1; fase <= 10; fase++)
        {
            //totalMOeda = totalMOeda + 3;
            totalMoeda += 3;

            print("O total de moedas at� agora �: " + totalMoeda);
        }

        print("Total de moedas: " + totalMoeda);

    }

    void Update()
    {
        
    }
}
