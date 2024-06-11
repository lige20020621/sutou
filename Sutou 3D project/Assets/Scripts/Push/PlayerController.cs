using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 moveDir;
    public float moveDistance = 1f;
    public float detectionDistance = 1f;
    public LayerMask obstacleLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            moveDir = Vector2.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            moveDir = Vector2.left;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            moveDir = Vector2.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            moveDir = Vector2.down;
        
        if(moveDir != Vector2.zero)
        {
            if(CanMoveToDir(moveDir))
            {
                Move(moveDir);
            }
        }

        moveDir = Vector2.zero;
    }

    bool CanMoveToDir(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position , dir, detectionDistance, obstacleLayer);
        if(!hit)
            return true;
        {
            if(hit.collider.GetComponent<Box>() != null)
                return hit.collider.GetComponent<Box>().CanMoveToDir(dir);
        }
        return false;
        
    }

    void Move(Vector2 dir)
    {
        transform.Translate(dir*moveDistance);
    }
}
