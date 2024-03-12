using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovent : MonoBehaviour
{
   public float speed = 0.1f;

    void Update()
    {
        // Mover la cámara hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
