using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject painelmenuinical;
    
    public void Jogar()
    {
        SceneManager.LoadScene("jogo");
    }

    public void Sair()
    {
        Debug.Log("Fechou");
        Application.Quit();
    }


}
