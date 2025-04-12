using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1.5f;
    public float miny = -1f;
    public float maxy = 2f;

    private float timer = 0f;

    void Update() 
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float yOffset = Random.range(miny, maxy);
        Vector3 spawnPos = new Vector3(transform.position.x, yOffset, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }

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
