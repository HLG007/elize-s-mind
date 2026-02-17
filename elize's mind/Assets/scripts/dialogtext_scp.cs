using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dialog_prefab_scp : MonoBehaviour
{

    public TextMeshProUGUI text;
    public float SPEEDTEXT = 0.2f;
    public TextMeshProUGUI nome;

    public AudioSource som;
    private bool playing = false;



    public string write_text;



    private void Start()
    {
        StartCoroutine(texto("pinto", write_text));
    }


    IEnumerator texto(string name, string texto)
    {
        text.text = "";
        for (int i = 0; i < texto.Length; i++)
        {
            nome.text = name;
            text.text += texto[i];
            if (som.isPlaying == false)
            {
                som.Play();
            }
            yield return new WaitForSeconds(SPEEDTEXT);
        }
    }
}