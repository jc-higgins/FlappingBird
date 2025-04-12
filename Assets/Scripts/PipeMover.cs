using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float speed = 250f;   
    public float leftBound = -200f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
