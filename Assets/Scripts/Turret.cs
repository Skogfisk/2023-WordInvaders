using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Animator animator;
    void Shooting()
    {
        animator.SetTrigger("Shoot");
        animator.SetTrigger("Explode");
    }
}
