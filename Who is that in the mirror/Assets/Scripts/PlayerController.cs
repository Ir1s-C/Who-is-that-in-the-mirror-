using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = 0f;
        movement.y = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1f;
            animator.Play("Andando para trás");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1f;
            animator.Play("Andando para frente");
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1f;
            animator.Play("Andando para Esquerda");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1f;
            animator.Play("Andando para Direita");
        }

        if (movement.magnitude == 0)
        {
            if (transform.localScale.x < 0)
            {
                animator.Play("Idle lado esquerdo");
            }
            else if (transform.localScale.x > 0)
            {
                animator.Play("Idle lado direito");
            }
            else if (movement.y > 0)
            {
                animator.Play("Idle trás");
            }
            else
            {
                animator.Play("Idle");
            }
        }
        movement = movement.normalized;
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}

