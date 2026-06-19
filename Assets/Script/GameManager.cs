using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // HUD
    public TextMeshProUGUI gameNameText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI msgText;

    // Controle
    public float score;
    public bool startGame;

    void Start()
    {
        scoreText.gameObject.SetActive(false);
        startGame = false;
    }
    public void StartGame()
    {
        startGame = true;
        score = 0;
        scoreText.gameObject.SetActive(true);
        gameNameText.gameObject.SetActive(false);
        msgText.gameObject.SetActive(false);
    }

    public void GameOver()
    { 
      gameNameText.gameObject.SetActive(true);
      gameNameText.text = "GAME OVER!!!";
      Invoke("RestartGame", 5f);
    }   
    
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    
    void Update()
    {
        if ( Input.GetKey(KeyCode.Space) == true && startGame == false)
        {
            StartGame();
        }
        scoreText.text = "Score: " + score;
    }
}
