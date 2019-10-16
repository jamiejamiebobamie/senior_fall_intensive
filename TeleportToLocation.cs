using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToLocation : MonoBehaviour
{

    public GameObject objectToTeleport;
    public GameObject newPositionObject;
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = newPositionObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Y))
        {
            objectToTeleport.transform.position = newPosition;
        }

    }
}
