using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBox : MonoBehaviour
{
    int a;
    private GameStateManager gameStateManager;
    public Animator myAnimator;
    public GameObject playButton;

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

    public void SwitchScene6()
    { 
        SceneManager.LoadScene(6);
    }
    public void SwitchScene7()
    {
        SceneManager.LoadScene(7);
    }

    public void OnClickSutou()
    {
        updateScore(1);
        if (gameStateManager.score >= 100)
        {
            gameStateManager.score = 0;
            SceneManager.LoadScene(8);
        } else {
            playButton.SetActive(false);
            myAnimator.SetBool("Sulike", true);
        }
    }

    private void updateScore(int val) {
        if(gameStateManager.score + val >= 100)
        {
            gameStateManager.score = 100;
        } else {
            gameStateManager.score += val;
        }
        gameStateManager.SaveGameState();
        gameStateManager.UpdateScoreText(); 
    }

    private void resetScore() {
        gameStateManager.score = 0;
        gameStateManager.SaveGameState();
    }

    void Update()
    {
        AnimatorStateInfo stateInfo = myAnimator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("sulike") && stateInfo.normalizedTime >= 1.0f)
        {
            myAnimator.SetBool("Sulike", false);
            myAnimator.SetBool("sutou1", true);
            playButton.SetActive(true);
        }
    }
    
}
