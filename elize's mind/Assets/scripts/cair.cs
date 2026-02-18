using UnityEngine;
using System.Collections;

public class cair : MonoBehaviour
{
    public void ComecarQueda()
    {
        StartCoroutine(Queda());
    }

    IEnumerator Queda()
    {
        for (int i = 0; i < 27; i++)
        {
            transform.position += new Vector3(0, -20, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
