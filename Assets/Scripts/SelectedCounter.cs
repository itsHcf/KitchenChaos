using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounter : MonoBehaviour
{

    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private List<GameObject> visualGameObjects = new List<GameObject>();
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += OnSelectedCounterChanged;
    }

    private void OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Select(true);
        }
        else
        {
            Select(false);
        }
    }

    private void Select(bool active)
    {
        foreach (GameObject go in visualGameObjects)
        {
            go.SetActive(active);
        }
    }



}
