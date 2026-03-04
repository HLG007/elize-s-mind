using UnityEngine;
using UnityEngine.InputSystem;

public class mov_player : MonoBehaviour
{
    private Vector2 movement;
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
