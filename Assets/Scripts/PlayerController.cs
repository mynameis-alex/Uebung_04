using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{

    //World Object which gets moved
    public GameObject world;

    //Camera
    public GameObject camera;

    //Initial Position
    Vector3 initialPosition;



    void Start()
    {
        initialPosition = camera.gameObject.transform.position;
    }

    void Update()
    {

        //direction vector between initialPos and cameraPos
        Vector3 directionVector = camera.transform.position - initialPosition;
        directionVector.y = initialPosition.y; //keep height the same


        //transfer function (for smoother transition we use an exponential function instead of linear)
        float distanceX = directionVector.x * directionVector.x * directionVector.x / 20;
        float distanceZ = directionVector.z * directionVector.z * directionVector.z / 20;

        //move world in other direction to simulate movement in the direction where user leans into
        Vector3 newPos = new Vector3(
            world.transform.position.x - distanceX,
            world.transform.position.y,
            world.transform.position.z - distanceZ
        );
        world.transform.position = newPos;

    }




}