using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    private IKitchenObjectParent kitchenObjectParent;

    public void SetBaseCounter(IKitchenObjectParent kitchenObjectParent)
    {
        if (this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.SetKitchenObject(null);
        }
        if (kitchenObjectParent == null)
        {
            transform.parent = null;
        }
        else
        {
            transform.parent = kitchenObjectParent.GetKitchenObjectSpawnPoint();
            transform.localPosition = Vector3.zero;
            kitchenObjectParent.SetKitchenObject(this);
        }
        this.kitchenObjectParent = kitchenObjectParent;
    }
}
