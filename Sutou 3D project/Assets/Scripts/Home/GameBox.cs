using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBox : MonoBehaviour
{
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
}
