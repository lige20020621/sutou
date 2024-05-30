using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameStateManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        LoadGameState();
    }

    // Method to save the game state
    public void SaveGameState()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
    }

    // Method to load the game state
    public void LoadGameState()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score");
        }
    }

    // Method to clear the game state
    public void ClearGameState()
    {
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.Save();
    }

      public void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
