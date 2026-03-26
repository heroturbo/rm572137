using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] private int inimigosPequenos;
    [SerializeField] private int inimigosMedios;
    [SerializeField] private int chefes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int xpP = inimigosPequenos * 10;
        int xpM = inimigosMedios * 25;
        int xpC = chefes * 100;
        int xpT = xpP + xpM + xpC;
        print("o total de XP recebido foi: " + xpT);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
