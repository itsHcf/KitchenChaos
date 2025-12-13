using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnPlayerGrabbedObject;
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(Player player)
    {
        if (GetKitchenObject() != null)
        {
            return;
        }
        Transform tomatoTransform = Instantiate(kitchenObjectSO.prefab);
        KitchenObject kitchenObject = tomatoTransform.GetComponent<KitchenObject>();
        kitchenObject.SetBaseCounter(player);

        OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
    }
}
