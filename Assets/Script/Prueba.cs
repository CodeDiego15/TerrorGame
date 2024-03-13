using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
   public Transform doorUp;
   public float doorSpeed;
   private bool doorOpen = false;
   private Vector3 initialDoorPosition;

    void Start()
    {
        initialDoorPosition = doorUp.position;

    }

    // Update is called once per frame
    void Update()
    {
         if(doorOpen)
        {
            doorUp.Translate(doorUp.up * doorSpeed * Time.deltaTime);
        }
        else
        {
           doorUp.position = initialDoorPosition;
        }
    }

      public void OpenDoor()
    {
        doorOpen = true;
    }

    public void closeDoor()
    {
        doorOpen = false;
    }
}
