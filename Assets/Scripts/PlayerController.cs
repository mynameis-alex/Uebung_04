using System;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{

    //World Object which gets moved
    public GameObject world;

    //Camera
    public GameObject camera;

    //Initial Position
    private Vector3 initialPosition;

    //Thresholds
    private float deadzone = 0.005f;
    private float maximum = 0.3f;



    void Start()
    {
        initialPosition = camera.gameObject.transform.position;
    }

    void Update()
    {

        //direction vector between initialPos and cameraPos
        Vector3 directionVector = camera.transform.position - initialPosition;
        directionVector.y = initialPosition.y; //keep height the same

        //set to zero if distance is below 0.1
        directionVector.x = (Math.Abs(directionVector.x) < deadzone) ? 0 : directionVector.x;
        directionVector.z = (Math.Abs(directionVector.z) < deadzone) ? 0 : directionVector.z;

        //cut when maximum is reached
        directionVector.x = (Math.Abs(directionVector.x) > maximum)
                    ? (directionVector.x < 0) ? 0 - maximum : maximum //maximum is negative when directionVector.x is negative
                    : directionVector.x;
        directionVector.z = (Math.Abs(directionVector.z) > maximum)
                    ? (directionVector.z < 0) ? 0 - maximum : maximum
                    : directionVector.z;

        //transfer function (for smoother transition we use an exponential function instead of linear)
        float distanceX = directionVector.x * directionVector.x * directionVector.x / 2;
        float distanceZ = directionVector.z * directionVector.z * directionVector.z / 2;

        //move world in other direction to simulate movement in the direction where user leans into
        Vector3 newPos = new Vector3(
            world.transform.position.x - distanceX,
            world.transform.position.y,
            world.transform.position.z - distanceZ
        );
        world.transform.position = newPos;

    }




}