using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushGameManager : MonoBehaviour
{
    public int totalBoxes;
    public int finishedBoxes;
    public void CheckFinish()
    {
        if(finishedBoxes == totalBoxes)
        {
            print("YOU WIN!");
        }
    }
}
