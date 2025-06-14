using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float timeElapsed = 0f;
    public int score = 0;
    private bool isGameOver = false;
    public GameObject gameOverPanel;


    void Update()
    {
        if (!isGameOver)
        {
            timeElapsed += Time.deltaTime;
            score = Mathf.FloorToInt(timeElapsed) * 2;
            scoreText.text = "Score: " + score;
        }
    }

    // Call this when player dies
    public void GameOver()
    {
        isGameOver = true;
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }
    public void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
