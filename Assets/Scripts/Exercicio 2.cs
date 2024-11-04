using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] bool powerUp;//true
    // ! > Invertendo o valor

    void Start()
    {
        if (powerUp == true)
        {
            print("Power-up Coletado!");
        }
        else
        {
            print("Nenhum power-up encontrado");
        }
        //condição ? Caso verdade : Caso falso
        
        print(powerUp  ? "Power-Up coletado!" : "Nenhum power-up coletado");

    }

    void Update()
    {
        
    }
}
