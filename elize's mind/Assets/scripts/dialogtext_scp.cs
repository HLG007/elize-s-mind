using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using UnityEditor;
using Unity.VisualScripting;

public class dialog_prefab_scp : MonoBehaviour
{

    public TextMeshProUGUI text;
    public float TEXTCOOLDOWN = 0.2f;
    public TextMeshProUGUI nome;
    private int algforlin = 96;

    public AudioSource som;

    private bool clicou = false;


    public string write_text;

    void Ontext_interact()
    {
        clicou = true;
        Debug.Log("adwa");
    }


    private void StartDialog(string nome, string texto)
    {
        StartCoroutine(escrever_texto(nome , texto));
    }


    IEnumerator escrever_texto(string name, string texto, int mode = 0)
    {
        string[] novotexto = textcodifiquer(texto);
        text.text = "";
        nome.text = name;


        for (int i = 0; i < novotexto.Length; i++)
        {

            if ((text.text.Length % algforlin + 1 + novotexto[i].Length + 1) > algforlin)
            {
                text.text += "\n";
            }
            for (int j = 0; j < novotexto[i].Length; j++)
            {
                text.text += novotexto[i][j];
                if (!som.isPlaying)
                {
                    som.Play();
                }
                yield return new WaitForSeconds(TEXTCOOLDOWN);

            }
            text.text += " ";
        }
        som.Stop();
    }


    private string[] textcodifiquer(string texto) // pega um texto e separa as palavras em uma lista ordenada
    {

        return texto.Split(' ');

    }


    

    /// <summary>
    /// Move o player na direção informada.
    /// </summary>
    /// <param name="direcao">Direção do movimento (Vector3).</param>
    /// <param name="velocidade">Velocidade do movimento.</param>
    
    public void start(string name, string texto)
    {
        //iniciar animação
        StartDialog(name, texto);
    }
    
    
}