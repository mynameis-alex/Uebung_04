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

    //Collision
    private GameObject collidedObject = null;



    void Start()
    {
        initialPosition = camera.gameObject.transform.position;
    }

    void Update()
    {

        //direction vector between initialPos and cameraPos
        Vector3 directionVector = camera.transform.position - initialPosition;
        directionVector.y = initialPosition.y; //keep height the same

        //check if moving into this direction would lead to a collision
        //if so -> forbid it
        if (willCollide(directionVector) == true)
        {
            return;
        }

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

    //check if user collides with an object (or at least its collider which is a bit larger)
    void OnTriggerEnter(Collider other)
    {
        //save object
        collidedObject = other.gameObject;
    }

    //register when collision ends (with collidedObject only)
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == collidedObject)
        {
            collidedObject = null;
        }
    }



    //check if user would collide with the colliderObject when he moves into the direction
    private Boolean willCollide(Vector3 direction)
    {

        //if collidedObject is null, there will be no collision
        if (collidedObject == null)
        {
            return false;
        }

        //check if player is moving towards the object which lead to a collision
        //if he is: block it to prevent collision
        //if not: allow movement so that he can move away
        Vector3 startPoint = transform.position;
        Vector3 endPoint = startPoint + (direction * 10); //end of linecast (a point further into the direction)
        RaycastHit hit;

        if (Physics.Linecast(startPoint, endPoint, out hit))
        {
            //check if the hitted object is the colliderObject
            return hit.collider.gameObject == collidedObject;
        }

        return false;

    }



}