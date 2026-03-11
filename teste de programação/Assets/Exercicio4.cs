using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private string Jogador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int moedas = 50;
        int NAmigos = 5;
        int resultado = moedas / NAmigos;
        print(Jogador + " tinha " + moedas + " e dividiu entre " + NAmigos + " amigos, cada amigo recebeu: " + resultado + " moedas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
