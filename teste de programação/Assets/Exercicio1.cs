using UnityEngine;

public class Exercicio1 : MonoBehaviour
{

    [SerializeField] private int a;
    [SerializeField] private int b;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int total = a + b;
        print("a + b = " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
