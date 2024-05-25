using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Rock,
    Stretch,
    Shorten
}
public class GameManage : MonoBehaviour
{
    private State state;
    private Vector3 dir;
    private Transform ropefather;
    private Transform ropeCode;
    private float length;

    public State GetState
    {
        set{ state = value; }
        get{ return state; }
    }
    void Start()
    {
        state = State.Rock;
        dir = Vector3.back;
        ropefather = transform.GetChild(0);
        ropeCode = ropefather.GetChild(0);
        length = 1;
    }


    void Update()
    {
        if (state == State.Rock)
        {
            Rock();
            if (Input.GetMouseButtonDown(0)) state = State.Stretch;
        }
        else if (state == State.Shorten)
        {
            Stretch();
        }
        else if (state == State.Stretch)
        {
            Shorten();
        }
    }
    private void Rock()
    {
        if (ropefather.localRotation.z <= -0.5f)
            dir = Vector3.forward;
        else if (ropefather.localRotation.z >= 0.5f)
            dir = Vector3.back;
        ropefather.Rotate(dir * 60 * Time.deltaTime);
    }
    private void Stretch()
    {
       if (length >= 7.5f) { state = State.Shorten;return; }
        length += Time.deltaTime ;
        ropefather.localScale = new Vector3(ropefather.localScale.x,length,ropefather.localScale.z);
        ropeCode.localScale = new Vector3(ropeCode.localScale.x, 1 / length, ropeCode.localScale.z);
    }
    private void Shorten()
    {
       if (length <= 1) { length = 1; state = State.Rock; return; }
        length -= Time.deltaTime ;
        ropefather.localScale = new Vector3(ropefather.localScale.x, length, ropefather.localScale.z);
        ropeCode.localScale = new Vector3(ropeCode.localScale.x, 1 / length, ropeCode.localScale.z);
    }

}
