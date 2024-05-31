using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scence : MonoBehaviour
{
    public void SwitchScene1()
    {
        SceneManager.LoadScene(1);
    }
}
