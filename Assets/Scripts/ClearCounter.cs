using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private GameObject selectedCounterVisual;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    [SerializeField] private Transform kitchenObjectSpawnPoint;

    private KitchenObject kitchenObject;

    // Press E key
    public void Interact()
    {
        if (kitchenObject != null)
        {
            return;
        }
        Transform tomatoTransform = Instantiate(kitchenObjectSO.prefab, KitchenObjectSpawnPoint);
        tomatoTransform.localPosition = Vector3.zero;
        kitchenObject = tomatoTransform.GetComponent<KitchenObject>();
        kitchenObject.SetClearCounter(this);
    }

    public void Select()
    {
        selectedCounterVisual.SetActive(true);
    }

    public void Deselect()
    {
        selectedCounterVisual.SetActive(false);
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

    public Transform KitchenObjectSpawnPoint => kitchenObjectSpawnPoint;

}
