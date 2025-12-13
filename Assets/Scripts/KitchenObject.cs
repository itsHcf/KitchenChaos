using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    private ClearCounter clearCounter;

    public void SetClearCounter(ClearCounter clearCounter)
    {
        if (this.clearCounter != null)
        {
            this.clearCounter.SetKitchenObject(null);
        }
        if (clearCounter == null)
        {
            transform.parent = null;
        }
        else
        {
            transform.parent = clearCounter.KitchenObjectSpawnPoint;
            clearCounter.SetKitchenObject(this);
        }
        this.clearCounter = clearCounter;
    }
}
