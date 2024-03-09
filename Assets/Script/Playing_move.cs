using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playing_move : MonoBehaviour
{
    
   public float runSpeed = 2;
   public float rotationSpeed = 100;
   public Animator animator;
   private float x, y;

    // Update is called once per frame
    void Update(){
         x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x*Time.deltaTime *rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime*runSpeed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}
