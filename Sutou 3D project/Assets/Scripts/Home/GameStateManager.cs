using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameStateManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject redbullAnimation;
    public GameObject normalAnimation;
    public int dressNumber;

    // Start is called before the first frame update
    void Start()
    {
        LoadGameState();
    }

    public void InitializedState()
    {
        score = 0;
        dressNumber = 0;
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("dressNumber", dressNumber);
        PlayerPrefs.Save();
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
         if (PlayerPrefs.HasKey("dressNumber"))
        {
            dressNumber = PlayerPrefs.GetInt("dressNumber");
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

    public void UpdateDress()
    {
        normalAnimation.SetActive(!(dressNumber == 1));
        redbullAnimation.SetActive(dressNumber == 1);
    }

    // Method to save the game state
    public void SaveDressState()
    {
        Debug.Log("SaveDressState");
        PlayerPrefs.SetInt("dressNumber", dressNumber);
        PlayerPrefs.Save();
    }
}
