﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour 
{
    private Text scoreText;
    private int currentScore = 0;
    private int newScoreValue = 1;

    private Scene scene;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scene = SceneManager.GetActiveScene();
        UpdateScore();
    }


    public void AddScore()
    {
        currentScore += newScoreValue;
        UpdateScore();
    }

    public void SubtractScore()
    {
        if (currentScore > 0) 
        {
            currentScore -= newScoreValue;
            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void RestartGame()
    {
        currentScore = 0;
        UpdateScore();
        SceneManager.LoadScene(scene.name);
    }
}
