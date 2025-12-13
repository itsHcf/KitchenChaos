using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    private BaseCounter baseCounter;

    public void SetClearCounter(BaseCounter baseCounter)
    {
        if (this.baseCounter != null)
        {
            this.baseCounter.SetKitchenObject(null);
        }
        if (baseCounter == null)
        {
            transform.parent = null;
        }
        else
        {
            transform.parent = baseCounter.GetKitchenObjectSpawnPoint();
            transform.localPosition = Vector3.zero;
            baseCounter.SetKitchenObject(this);
        }
        this.baseCounter = baseCounter;
    }
}
