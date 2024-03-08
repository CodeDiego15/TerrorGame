using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playing_move : MonoBehaviour
{
    public CharacterController controller;
   public float runSpeed = 2;
   public float rotationSpeed = 100;

   public float gravity = -9.8f;
    public float jumpForce = 10f;
    public float distance = 0.3f;
    bool isGrounded;

    Vector3 velocity;
   Animator animator;
   private float x, y;

    // Update is called once per frame
    void Update(){
         x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x*Time.deltaTime *rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime*runSpeed);

        animator.SetFloat("VeX", x);
        animator.SetFloat("VeY", y);
        
    }
}
