using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int danoBase = 15;
        int bonusArma = 5;
        int bonusTemp = 2;
        int danoTotal = (danoBase + bonusArma) * bonusTemp;
        print("o dano total foi: " + danoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
