using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    int count = 0;
    public float moveDistance = 50f; // Distance to move up
    private Vector3 originalPosition; // Store the original position of the GameObject

    void Start()
    {
        // Store the original position
        originalPosition = transform.position;
    }

    public void SwitchScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void SwitchScene3()
    {
        if(count < 3) {
            transform.Translate(Vector3.up * moveDistance);
            count++;
        } else {
            count = 0;
            SceneManager.LoadScene(3);
        }
    }
}
