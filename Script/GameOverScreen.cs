
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public GameObject gameOverPanel; 
    

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pit"))
        {
            Debug.Log("Pit hit!");
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f; // pause game
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // resume game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}