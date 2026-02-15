using UnityEngine;
using UnityEngine.InputSystem;

public class mov_player : MonoBehaviour
{

    private Vector2 inputo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMove(InputValue value)
    {
        inputo = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)inputo*0.01f;
    }
}
