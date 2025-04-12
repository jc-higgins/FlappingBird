using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 3f;
    public float miny = -300f;
    public float maxy = 600f;

    private float timer = 0f;

    // On update, check time diff against timer and move left
    void Update() 
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    // Spawn a pipe gate with a random offset
    void SpawnPipe()
    {
        float yOffset = Random.Range(miny, maxy);
        Vector3 spawnPos = new Vector3(transform.position.x, yOffset, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
