using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private GameObject selectedCounterVisual;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    [SerializeField] private Transform KitchenObjectSpawnPoint;

    private KitchenObject kitchenObject;

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
}
