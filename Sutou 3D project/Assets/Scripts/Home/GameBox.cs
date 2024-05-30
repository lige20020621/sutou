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
    }
    public void SwitchScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void SwitchScene4()
    {
        SceneManager.LoadScene(4);
    }

    public void SwitchScene5()
    {
        SceneManager.LoadScene(5);
    }

    public void OnClickSutou()
    {
        gameStateManager.score += 1;
        gameStateManager.SaveGameState();
        gameStateManager.UpdateScoreText(); 
    }
}
