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

        //transfer function
        float distanceX = directionVector.x * directionVector.x / 2;
        float distanceZ = directionVector.z * directionVector.z / 2;

        //new pos of world
        Vector3 newPos = new Vector3(
            world.transform.position.x + distanceX,
            world.transform.position.y,
            world.transform.position.z + distanceZ
        );
        world.transform.position = newPos;

    }




}