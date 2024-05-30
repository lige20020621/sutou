using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBox : MonoBehaviour
{
    private GameStateManager gameStateManager;

    void Start()
    {   
        gameStateManager = FindObjectOfType<GameStateManager>();
        gameStateManager.LoadGameState(); // Load the game state when the player is initialized
        gameStateManager.UpdateScoreText();
         if(gameStateManager.score >= 100) {
            resetScore();
            SceneManager.LoadScene(8);
        }
    }
    public void SwitchScene2()
    {
        updateScore(20);
        SceneManager.LoadScene(2);
    }

    public void SwitchScene4()
    {
        updateScore(20);
        SceneManager.LoadScene(4);
    }

    public void SwitchScene5()
    {
        updateScore(20);
        SceneManager.LoadScene(5);
    }

    public void OnClickSutou()
    {
       updateScore(1);
        if(gameStateManager.score >= 100) {
            gameStateManager.score = 0;
            SceneManager.LoadScene(8);
        }
    }

    private void updateScore(int val) {
        gameStateManager.score += val;
        gameStateManager.SaveGameState();
        gameStateManager.UpdateScoreText(); 
    }

    private void resetScore() {
        gameStateManager.score = 0;
        gameStateManager.SaveGameState(); 
    }

    void Update()
    {}
}
