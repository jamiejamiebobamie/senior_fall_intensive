using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfWDelay : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        /*
         * Destroy takes two arguments : a gme object to "destroy"
         * and an optional delay.
         * the first argument is optional too and the game component that the
         * the script is attached to will be destroyed
         * if no GameObject is passed in.
         */

     Destroy(gameObject, 7f);
    }
}
