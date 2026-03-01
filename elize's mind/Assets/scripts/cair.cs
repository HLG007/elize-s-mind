using UnityEngine;
using System.Collections;

public class cair : MonoBehaviour

{
    bool estaMovendo = false;

    public void Descer()
    {
        if (!estaMovendo)
            StartCoroutine(Mover(-1));
    }

    public void Subir()
    {
        if (!estaMovendo)
            StartCoroutine(Mover(1));
    }

    IEnumerator Mover(int direcao)
    {
        estaMovendo = true;

        for (int i = 0; i < 50; i++)
        {
            transform.position += new Vector3(0, direcao * 25, 0);
            yield return new WaitForSeconds(0.005f);
        }

        estaMovendo = false;
    }
}

