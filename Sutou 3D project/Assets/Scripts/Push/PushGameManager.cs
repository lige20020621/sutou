using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushGameManager : MonoBehaviour
{
    public int totalBoxes;
    public int finishedBoxes;
    public bool CheckFinish()
    {
        return finishedBoxes == totalBoxes;
    }
    public void goBack()
    {
        SceneManager.LoadScene(1);
    }
}
