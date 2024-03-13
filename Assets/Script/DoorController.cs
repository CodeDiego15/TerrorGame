using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform leftDoor;
    public Transform rightDoor;
    public float doorSpeed = 5f;
    public float doorWidth = 1f;

    private bool leftDoorOpen = false;
    private bool rightDoorOpen = false;

    private Vector3 initialLeftDoorPosition;
    private Vector3 initialRightDoorPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialLeftDoorPosition = leftDoor.position;
        initialRightDoorPosition = rightDoor.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(rightDoorOpen)
        {
            rightDoor.Translate(rightDoor.forward * doorSpeed * Time.deltaTime);
        }
        else
        {
            rightDoor.position = initialRightDoorPosition;
        }

         if(leftDoorOpen)
        {
            leftDoor.Translate(leftDoor.forward * doorSpeed * Time.deltaTime);
        }
        else
        {
            leftDoor.position = initialLeftDoorPosition;
        }
     
    }

    public void OpenLeftDoor()
    {
        leftDoorOpen = true;
    }

    public void CloseLeftDoor()
    {
        leftDoorOpen = false;
    }

    public void OpenRightDoor()
    {
        rightDoorOpen = true;
    }

    public void CloseRightDoor()
    {
        rightDoorOpen = false;
    }
}
