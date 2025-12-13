using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    // Start is called before the first frame update
    private ClearCounter clearCounter;


    public void SetClearCounter(ClearCounter clearCounter)
    {
        this.clearCounter = clearCounter;
        if (clearCounter == null)
        {
            transform.parent = null;
        }
    }
}
