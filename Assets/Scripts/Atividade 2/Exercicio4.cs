using UnityEngine;

public class Exercicio04repeticao : MonoBehaviour

/*(Pontua��o em combos) Cada combo realizado aumenta em 10
pontos. Exiba a pontua��o total ap�s 7 combos.*/
{
    [SerializeField] int combo = 0;
    void Start()
    {
        for (int i = 1; i <= 7; i++)
        {
            combo += 10;
        }


        print(combo);
    }


    void Update()
    {

    }
}