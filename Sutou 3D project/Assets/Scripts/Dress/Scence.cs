using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scence : MonoBehaviour
{
    private GameStateManager gameStateManager;

    void Start()
    { 
        gameStateManager = FindObjectOfType<GameStateManager>();
        gameStateManager.LoadGameState(); 
    }
    public void SwitchScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeDress() {
        gameStateManager.dressNumber = 1;
        gameStateManager.SaveDressState();
    }
}
