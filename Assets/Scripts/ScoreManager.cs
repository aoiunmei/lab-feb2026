using UnityEngine;
using UnityEngine.UI;
using TMPro; // Remove this if you're not using TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [Header("Score Settings")]
    public int currentScore = 0;

    [Header("UI Reference")]
    public TextMeshProUGUI scoreText; 
    // If using normal UI Text, change to:
    // public Text scoreText;

    private void Awake()
    {
        // Singleton Setup
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional (remove if not needed)
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        UpdateScoreUI();
    }

    public void SubtractScore(int amount)
    {
        currentScore -= amount;
        UpdateScoreUI();
    }

    public void ResetScore()
    {
        currentScore = 0;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
    }
}