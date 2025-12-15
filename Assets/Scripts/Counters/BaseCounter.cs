using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{

    [SerializeField] private Transform kitchenObjectSpawnPoint;
    private KitchenObject kitchenObject;

    public virtual void Interact(Player player)
    {
        // This method is meant to be overridden in derived classes
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public Transform GetKitchenObjectSpawnPoint() => kitchenObjectSpawnPoint;

}
