using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public cair objetoQueVaiCair;

    public void Jogar()
    {
        SceneManager.LoadScene("jogo");
    }

    public void Opções()
    {
        objetoQueVaiCair.ComecarQueda();
    }

    public void Sair()
    {
        Debug.Log("Fechou");
        Application.Quit();
    }


}
