using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Box : MonoBehaviour
{
    public GameObject pushOkOne;
    public GameObject pushOkTwo;
    public GameObject clearImage;
    public GameObject home;
    public bool isPushable = true;
    private void Start() 
    {
        FindObjectOfType<PushGameManager>().totalBoxes++;
        pushOkOne.SetActive(false);
        pushOkTwo.SetActive(false);
        clearImage.SetActive(false);
        home.SetActive(false);
    }
    public bool CanMoveToDir(Vector2 dir)
    {
        if (!isPushable)
        {
            return false;
        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3)dir * 0.5f, dir, 0.5f);
        if(!hit)
        {
            transform.Translate(dir);
            return true;
        }

        return false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("target"))
        {
            Debug.Log("inside target");
            string collidedObjectName = collision.gameObject.name;
            if(collidedObjectName == "targetOne")
            {
                pushOkOne.SetActive(true);
            }
            if(collidedObjectName == "targetTwo")
            {
                pushOkTwo.SetActive(true);
            }
            isPushable = false; // Disable pushing
            FindObjectOfType<PushGameManager>().finishedBoxes++;
            bool isClear =  FindObjectOfType<PushGameManager>().CheckFinish();
            if(isClear)
            {
                 clearImage.SetActive(true);
                 home.SetActive(true);
            }
        }
    }
}
