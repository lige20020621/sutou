using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOb : MonoBehaviour
{
    private GameManage gameManage;
    public Transform ropeTransform;
    public Image passImage;
    public Image justRockImage;

    void Start()
    {
        GameObject gameManagerObject = GameObject.Find("Gamemange");
        gameManage = gameManagerObject.GetComponent<GameManage>();
        if (gameManage == null)
        {
            Debug.LogError("GameManage component not found on the same GameObject.");
        }

         if (ropeTransform == null)
        {
            ropeTransform = transform;
        }

      
        if (passImage == null)
        {
            Debug.LogError("passImage Image component not found on this GameObject.");
            
        }
        


        if (justRockImage == null)
        {
            Debug.LogError("justRockImage Image component not found on this GameObject.");
            
        }
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!IsItemAttached()) {
            if (other.CompareTag("rock"))
            {
                other.transform.parent = transform;
                gameManage.GetState = State.Shorten;
                transform.GetComponent<Collider2D>().enabled = false;
                passImage.enabled = false;
            } else if (other.CompareTag("student")) {
                other.transform.parent = transform;
                gameManage.GetState = State.Shorten;
                transform.GetComponent<Collider2D>().enabled = false;
                justRockImage.enabled = false;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "Rock"
        if (collision.gameObject.CompareTag("rock"))
        {
            Debug.Log("Handler collided with a rock!");
            // Perform actions when the handler collides with a rock
        }
    }

    bool IsItemAttached()
    {
        // Check each child of the ropeTransform to see if any of them have the tag "Rock"
        foreach (Transform child in ropeTransform)
        {
            if (child.CompareTag("rock") || child.CompareTag("student"))
            {
                return true; // A rock is already attached
            }
        }
        return false; // No rock is attached
    }
}
