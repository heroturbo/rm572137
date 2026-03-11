using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    [SerializeField] private string funcionario;
    [SerializeField] private float salariophora;
    [SerializeField] private float horastrabalhadas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float salariototal = salariophora * horastrabalhadas;
        print(funcionario + " seu pagamento é: R$" + salariototal);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
