using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovent : MonoBehaviour
{
    
    
    private Collider col;
    public Animator animator;
    public float speed = 3f;
    private float x;
    void Start()
    {
        
        
        animator.SetFloat("VelX", x);
        
    }

    void DisableCollider()
    {
        
    }
}

