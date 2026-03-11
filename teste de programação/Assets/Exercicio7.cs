using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    [SerializeField] public float numero1;
    [SerializeField] public float numero2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float total = numero1 + numero2;
        print(numero1 + " + " + numero2 + " = " + total);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
