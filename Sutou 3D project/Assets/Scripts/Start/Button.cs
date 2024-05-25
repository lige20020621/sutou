using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void SwitchScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void SwitchScene3()
    {
        SceneManager.LoadScene(3);
    }
}
