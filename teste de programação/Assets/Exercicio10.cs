using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] float salario = 1000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float total = salario + (salario * 0.10f);
        print("total = " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
