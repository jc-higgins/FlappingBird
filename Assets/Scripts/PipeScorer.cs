using UnityEngine;

public class PipeScorer : MonoBehaviour
{
    private bool scored = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!scored && other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1);
            scored = true;
        }
    }
}
