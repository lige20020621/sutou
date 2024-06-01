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
        Debug.Log("Start Scence");
        gameStateManager = FindObjectOfType<GameStateManager>();
        gameStateManager.LoadGameState(); 
    }
    public void SwitchScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeDress() {
        Debug.Log("ChangeDress");
        gameStateManager.dressNumber = 1;
        gameStateManager.SaveDressState();
    }
}
