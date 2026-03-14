using Unity.Collections;
using UnityEngine;

public class iasmimgay : MonoBehaviour
{

    public string nome_jogador1;
    public string nome_jogador2;

    public string escolha_jogador1;
    string escolha_jogador2;

    public int numero_jogador1;
    public int numero_jogador2;

    string vencedor;



    public enum seila
    {
        a,
        b,
        c,
        d,
        awdawda,
        asdwada
    }


    public seila seliawdan;


    void Start()
    {
        if ((numero_jogador1 + numero_jogador2) % 2 == 0)
        {
            if (escolha_jogador1 == "par")
            {
                vencedor = nome_jogador1;
            }
            else
            {
                vencedor = nome_jogador2;
            }
        }
        else
        {
            if (escolha_jogador1 == "impar")
            {
                vencedor = nome_jogador1;
            }
            else
            {
                vencedor = nome_jogador2;
            }
        }

        Debug.Log("O vencedor é " + vencedor);

    }
}
