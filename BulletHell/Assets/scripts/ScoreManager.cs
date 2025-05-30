using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score.ToString();
    }

    
    public static ScoreManager Instance;

    public GameObject gameWinCanvas;

    void Awake()
    {
        Instance = this;
        gameWinCanvas.SetActive(false); // Ocultar al inicio
    }

    public void WinGame()
    {
        Debug.Log("¡Ganaste!");
        if (gameWinCanvas != null)
        {
            gameWinCanvas.SetActive(true);
        }

        // Opcional: Pausar juego
        Time.timeScale = 0f;
    }

}