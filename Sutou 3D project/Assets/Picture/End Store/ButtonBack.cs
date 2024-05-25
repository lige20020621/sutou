using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBack : MonoBehaviour
{
    public void SwitchScene0()
    {
        SceneManager.LoadScene(0);
    }
}
