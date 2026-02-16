using UnityEngine;
using UnityEngine.InputSystem;

public class mov_player : MonoBehaviour
{
    public float velocidade = 0.01f;
    private Vector2 inputo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMove(InputValue value)
    {
        inputo = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)inputo*velocidade;
    }
}
