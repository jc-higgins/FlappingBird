using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flapForce = 25f;
    
    private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    void Flap()
    {
        // Reset velocity to zero
        rb.linearVelocity = Vector2.zero;

        // Apply upward force
        rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);

        animator.SetTrigger("Flap");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!GameManager.Instance.isGameOver)
        {
            GameManager.Instance.GameOver();
        }
    }
}
