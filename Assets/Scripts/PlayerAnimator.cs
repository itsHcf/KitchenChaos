using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    const string IS_WALKING = "IsWalking";

    private Animator animator;

    [SerializeField]private PlayerComponent playerComponent;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (playerComponent == null)
        {
            return;
        }
        animator.SetBool(IS_WALKING, playerComponent.IsWalking());
    }
}
