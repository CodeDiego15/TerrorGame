using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundZombie : MonoBehaviour
{
      public AudioSource audioSource;
    public Transform personaje;
    public float distanciaAtenuacion = 10f;

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, personaje.position);
        float volumen = 1 - (distancia / distanciaAtenuacion);
        
        if (volumen < 0)
        {
            volumen = 0;
        }
        
        audioSource.volume = volumen;
    }

    
}
