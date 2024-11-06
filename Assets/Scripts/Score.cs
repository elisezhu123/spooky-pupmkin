using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    public int score = 0;
    public bool GameOver;
    public TextMeshProUGUI scoreboard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0; 
        GameOver = false;
        scoreboard.text = "0";
    }

    // Update is called once per frame
   void Update()
    {
        if (GameOver)
        {
            TriggerGameOver();
        }
    }

    public void AddScore()
    {
        score++;
        scoreboard.text = score.ToString();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void TriggerGameOver()
    {
        GameOver = true;
        SceneManager.LoadScene(2); // Load the Game Over scene (scene index 1)
    }

}
 // End of the namespace
