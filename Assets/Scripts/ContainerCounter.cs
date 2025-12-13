using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact()
    {
        if (GetKitchenObject() != null)
        {
            return;
        }
        Transform tomatoTransform = Instantiate(kitchenObjectSO.prefab);
        KitchenObject kitchenObject = tomatoTransform.GetComponent<KitchenObject>();
        kitchenObject.SetClearCounter(this);
    }
}
