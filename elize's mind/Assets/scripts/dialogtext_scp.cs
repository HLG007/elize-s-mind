using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class dialog_prefab_scp : MonoBehaviour
{

    public TextMeshProUGUI text;
    public float TEXTCOOLDOWN = 0.2f;
    public TextMeshProUGUI nome;

    public AudioSource som;



    public string write_text;



    private void Start()
    {
        StartCoroutine(textoo(nome.text, write_text));
    }


    IEnumerator textoo(string name, string texto)
    {
        string[] novotexto = textcodifiquer(texto);
        text.text = "";
        nome.text = name;


        for (int i = 0; i < novotexto.Length; i++)
        {

            if ((text.text.Length % 97 + novotexto[i].Length + 1) > 96)
            {
                text.text += "\n";
            }
            for (int j = 0; j < novotexto[i].Length; j++)
            {
                text.text += novotexto[i][j];
                yield return new WaitForSeconds(TEXTCOOLDOWN);
            }
            text.text += " ";
        }
    }


    private string[] textcodifiquer(string texto) // pega um texto e separa as palavras em uma lista ordenada
    {

        return texto.Split(' ');

    }



}