using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// use inut manager and buttons ass opposed to keys === best practices.
public class ButtonPresses : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //this works but it happens too quickly to see
        // true for one frame when the button is pressed.
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        // true while the button is held down
        else if (Input.GetKey(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        // true for one frame after letting up the key / button
        else if (Input.GetKeyUp(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }


    }
}
