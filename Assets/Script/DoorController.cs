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
        if (leftDoorOpen)
        {
            leftDoor.position = Vector3.MoveTowards(leftDoor.position, initialLeftDoorPosition + new Vector3(doorWidth, 0, 2.7f), doorSpeed * Time.deltaTime);
        }
        else
        {
            leftDoor.position = Vector3.MoveTowards(leftDoor.position, initialLeftDoorPosition, doorSpeed * Time.deltaTime);
        }

        if (rightDoorOpen)
        {
            rightDoor.position = Vector3.MoveTowards(rightDoor.position, initialRightDoorPosition - new Vector3(doorWidth, 0.02f, -2.14f), doorSpeed * Time.deltaTime);
        }
        else
        {
            rightDoor.position = Vector3.MoveTowards(rightDoor.position, initialRightDoorPosition, doorSpeed * Time.deltaTime);
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
