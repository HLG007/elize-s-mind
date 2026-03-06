using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //importamos a funcionalidade de cenas para conseguir mexer em cenas

public class menu : MonoBehaviour
{
    public RectTransform objeto;
    public float duracao = 1.5f;
    public string nomeCena;

    public void ApertouBotao()
    {
        StartCoroutine(Animacao());
    }

    IEnumerator Animacao()
    {
        Vector3 escalaInicial = objeto.localScale;
        Vector3 escalaFinal = Vector3.zero;

        float tempo = 0;

        while (tempo < duracao)
        {
            tempo += Time.deltaTime;

            float t = tempo / duracao;
            t = Mathf.SmoothStep(0, 1, t);

            objeto.localScale = Vector3.Lerp(escalaInicial, escalaFinal, t);

            yield return null;
        }

        SceneManager.LoadScene(nomeCena);
    }

    public void Jogar() //Declaro uma função jogar
    {
        SceneManager.LoadScene("jogo"); //Quando chamar o função jogar, a cena muda para a do jogo.
    }

    public void Sair() //Declaro uma função chamada sair
    {
        Application.Quit(); //Fecha o aplicativo
    }
}

