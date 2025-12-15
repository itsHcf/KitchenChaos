using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    const string IS_WALKING = "IsWalking";

    private Animator animator;

    [SerializeField] private Player player;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (player == null || animator == null)
        {
            return;
        }
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
