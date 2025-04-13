using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool isGameOver = false;

    public GameObject gameOverPanel;

    void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            Debug.Log("GameManager initialized");
        }
        else Destroy(gameObject);
    }

    void Start()
    {
        if (gameOverPanel != null)
        {
            Debug.Log("GameOverPanel found, setting inactive");
            gameOverPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("GameOverPanel is not assigned in the GameManager!");
        }

        // Check Canvas setup
        Canvas canvas = FindFirstObjectByType<Canvas>();
        if (canvas != null)
        {
            Debug.Log($"Canvas found: RenderMode={canvas.renderMode}, SortingOrder={canvas.sortingOrder}");
        }
        else
        {
            Debug.LogError("No Canvas found in the scene!");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over triggered");

        if (gameOverPanel != null)
        {
            Debug.Log("Activating GameOverPanel");
            gameOverPanel.SetActive(true);
            
            // Force Canvas update
            Canvas.ForceUpdateCanvases();
        }
        else
        {
            Debug.LogError("GameOverPanel is null during GameOver!");
        }
        
        // Stop time
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void RestartGame()
    {
        Time.timeScale = 2f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
