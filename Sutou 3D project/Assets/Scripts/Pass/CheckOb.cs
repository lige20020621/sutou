using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOb : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.parent = transform;
        transform.root.GetComponent<GameManage>().GetState = State.Shorten;
    }
}
