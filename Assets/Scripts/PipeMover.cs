using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float speed = 2f;   
    public float leftBound = -10f;

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
