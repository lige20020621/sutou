using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum State
{
    Rock,
    Stretch,
    Shorten,
}
public class GameManage : MonoBehaviour
{
    private State state;
    private Vector3 dir;
    public Image rope;
    public Image handler;
    public Image passImage;
    public Image justRockImage;
    public Image allPassImage;
    public List<Transform> studentImages;
    public GameObject homeButton;
    private float length;
    private bool isRotating = true;

    public State GetState
    {
        set{ state = value; }
        get{ return state; }
    }
    void Start()
    {
        state = State.Rock;
        dir = Vector3.back;
        length = 1;
        homeButton.SetActive(false);
        allPassImage.enabled = false;
    }


    void Update()
    {
        if (state == State.Rock)
        {
            if(isRotating) Rock();
            if (Input.GetMouseButtonDown(0) && isRotating) state = State.Stretch;
        }
        else if (state == State.Shorten)
        {
            Shorten();
        }
        else if (state == State.Stretch)
        {
            Stretch();
        }
    }
    private void Rock()
    {
        if (rope.rectTransform.localRotation.z <= -0.5f)
            dir = Vector3.forward;
        else if (rope.rectTransform.localRotation.z >= 0.5f)
            dir = Vector3.back;
        rope.rectTransform.Rotate(dir * 60 * Time.deltaTime);
    }
    private void Stretch()
    {
     if (length >= 4f) { state = State.Shorten;return; }
        length += Time.deltaTime ;
        rope.rectTransform.localScale = new Vector3(rope.rectTransform.localScale.x,length,rope.rectTransform.localScale.z);
        handler.rectTransform.localScale = new Vector3(handler.rectTransform.localScale.x, 1 / length, handler.rectTransform.localScale.z);
    }
    public void Shorten()
    {
       if (length <= 1) { 
            length = 1; 
            state = State.Rock; 
            handler.GetComponent<Collider2D>().enabled = true; 
            // if no child
            if(handler.transform.childCount > 0) {
                Transform firstChildTransform = handler.transform.GetChild(0);
                if(firstChildTransform.CompareTag("student")) {
                    Debug.Log("it is a rock");
                    studentImages.Remove(firstChildTransform);
                }
                Destroy(firstChildTransform.gameObject);
                if(!IsPassImageEnabled())
                {
                    passImage.enabled = true;
                }
                if(!IsRockImageEnabled())
                {
                    justRockImage.enabled = true;
                }
            }
            if(studentImages.Count == 0)
            {
                isRotating = false;
                homeButton.SetActive(true);
                allPassImage.enabled = true;
                Debug.Log("no student");
            }
            return; 
        }
        length -= Time.deltaTime ;
        rope.rectTransform.localScale = new Vector3(rope.rectTransform.localScale.x, length, rope.rectTransform.localScale.z);
        handler.rectTransform.localScale = new Vector3(handler.rectTransform.localScale.x, 1 / length, handler.rectTransform.localScale.z);
    }

    bool IsPassImageEnabled()
    {
        if (passImage != null)
        {
            return passImage.enabled;
        }
        return false;
    }

    bool IsRockImageEnabled()
    {
        if (justRockImage != null)
        {
            return justRockImage.enabled;
        }
        return false;
    }

    public void SwitchToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
