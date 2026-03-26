using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] public float velocidadeinicial;
    [SerializeField] public float aceleracao;
    [SerializeField] public float tempo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float velocidadeFinal = velocidadeinicial + aceleracao * tempo;
        print("a velocidade final é: " + velocidadeFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
