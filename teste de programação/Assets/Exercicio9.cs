using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    [SerializeField] public float numero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float dobro = numero * 2;
        float metade = numero / 2;
        print("o dobro de " + numero + " é " + dobro);
        print("a metade de " + numero + " é " + metade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
