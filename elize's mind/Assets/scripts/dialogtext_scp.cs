using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class dialog_prefab_scp : MonoBehaviour
{



    public TextMeshProUGUI text;
    public float TEXTCOOLDOWN;
    public float TEXTCOOLDOWN2;
    public TextMeshProUGUI nome;
    private int algforlin = 96;
    public GameObject painelvisible;

    public AudioSource som;

    private bool clicou = false;
    private bool esperandoclick = false;
    private bool esperandoskipclick = false;
    private bool skipclick = false;


    public string write_text;





    #region start functions
    public void Start()
    {
        painelvisible.SetActive(false);

    }
    #endregion



    #region click



    public void OnSkip(InputAction.CallbackContext context)
    {
        
        if (context.performed && esperandoskipclick)
        {
            skipclick = true;
        }
    }




    public void OnInteract(InputAction.CallbackContext context)
    {
        
        if (context.performed)
        {


            if (esperandoclick)
            {
                clicou = true;

            }
            else
            {
                clicou = false;
                TEXTCOOLDOWN = TEXTCOOLDOWN2 / 3f;
            }

        }


        if (context.canceled && TEXTCOOLDOWN < TEXTCOOLDOWN2)
        {
            TEXTCOOLDOWN = TEXTCOOLDOWN2;
        }

    }






    #endregion


    #region start coroutime function

    public IEnumerator ds(string nome, string texto, bool finalize = false)
    {
        globalvariable.canmove = false;
        painelvisible.SetActive(true);
        yield return StartCoroutine(escrever_texto(nome, texto));
        esperandoclick = true;
        yield return new WaitUntil(() => clicou == true);
        esperandoclick = false;
        clicou = false;
        if (finalize)
        {
            painelvisible.SetActive(false);
            globalvariable.canmove = true;
        }

    }

    public IEnumerator d(string nome, string texto)
    {
        yield return StartCoroutine(escrever_texto(nome, texto));
        esperandoclick = true;
        yield return new WaitUntil(() => clicou == true);
        esperandoclick = false;
        clicou = false;
    }

    public IEnumerator df(string nome, string texto)
    {

        yield return StartCoroutine(escrever_texto(nome, texto));
        esperandoclick = true;
        yield return new WaitUntil(() => clicou == true);
        esperandoclick = false;
        clicou = false;
        painelvisible.SetActive(false);
        globalvariable.canmove = true;
    }


    #endregion


    IEnumerator escrever_texto(string nomea, string texto)
    {
        string[] novotexto = texto.Split(' ');
        text.text = "";
        nome.text = nomea;

        esperandoskipclick = true;
        for (int i = 0; i < novotexto.Length; i++)
        {

            if ((text.text.Length % algforlin + 1 + novotexto[i].Length + 1) > algforlin)
            {
                text.text += "\n";
            }
            for (int j = 0; j < novotexto[i].Length; j++)
            {
                text.text += novotexto[i][j];
                if (skipclick)
                {
                    text.text = texto;
                    esperandoskipclick = false;
                    skipclick = false;
                    yield break;
                }
                if (!som.isPlaying)
                {
                    som.Play();
                }
                yield return new WaitForSeconds(TEXTCOOLDOWN);

            }
            text.text += " ";
        }
        som.Stop();
        esperandoskipclick = false;
    }




}