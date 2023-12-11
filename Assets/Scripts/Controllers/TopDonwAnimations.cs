using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDonwAnimations : MonoBehaviour
{
    protected Animator animator;
    protected TopDownCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownCharacterController>();
    }
}
