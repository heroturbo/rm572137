using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    [SerializeField] int vida = 100;
    [SerializeField] int dano;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int vidafinal = vida - dano;
        print("jogador tinha " + vida + " de vida e tomou " + dano + " de dano, restando: " + vidafinal + " de vida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
