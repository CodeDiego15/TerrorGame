using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCambio : MonoBehaviour
{
   public GameObject camara1, camara2;
    void Start()
    {
        
    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            camara1.SetActive(false);
            camara2.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
           if(other.gameObject.tag == "Player")
        {
            camara1.SetActive(true);
            camara2.SetActive(false);
        }
    }
}
