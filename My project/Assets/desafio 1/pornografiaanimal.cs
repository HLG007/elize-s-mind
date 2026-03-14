using UnityEngine;

public class pornografiaanimal : MonoBehaviour
{
    
    [SerializeField] private float a;
    [SerializeField] private float b;
    [SerializeField] private float c;

    private string resultado = "escaleno";




    void Start()
    {
        if (a == b & a == c)
        {
            resultado = "equilatero";
        }
        else if ((b == c & b != a) | (a == c & c != b) | (b == a & a != c))
        {
            resultado = "isósceles";
        }

        Debug.Log("o seu mini triangulozinho é " + resultado);


    }
}
