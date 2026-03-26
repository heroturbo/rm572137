using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    [SerializeField] public int pontosBase;
    [SerializeField] public int inimigosDerrotados;
    [SerializeField] public int bonus;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
        print("a pontuação final é: " + pontuacaoFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
