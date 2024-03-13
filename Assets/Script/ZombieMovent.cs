using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovent : MonoBehaviour
{
    
public float speed = 5f;
    private Collider collider;
    private float x;
    public Animator animator;
        
    void Start()
    { 
        animator.SetFloat("VelX", x);
        collider = GetComponent<Collider>();
        Invoke("DisableCollider", 3f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void DisableCollider()
    {
        collider.enabled = false;
    }
}
