using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] private string jogador;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int vidamax = 100;
        int dano = 25;
        int vidatotal = vidamax - dano;
        print(jogador + " recebeu " + dano + " de dano e ficou com: " + vidatotal + " de hp.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
