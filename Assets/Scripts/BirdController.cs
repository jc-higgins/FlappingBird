using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flapForce = 25f;
    
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
    }
}
