using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOb : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        // other.transform.parent = transform;
        // transform.root.GetComponent<GameManage>().GetState = State.Shorten;
        // transform.GetComponent<Collider2D>().enabled = false;
        if (other.CompareTag("rock"))
        {
            // Add your logic for when the rope collides with a rock
            Debug.Log("Collided with a rock!");

            // Example: Decrease the rope length or perform some other action
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // This function is called when another collider exits the trigger collider attached to the object where this script is attached.
        Debug.Log("Trigger Exited by: " + other.name);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        // This function is called once per frame for every collider that is touching the trigger collider attached to the object where this script is attached.
        Debug.Log("Trigger Staying with: " + other.name);
    }
}
