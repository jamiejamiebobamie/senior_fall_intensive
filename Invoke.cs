using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // you can call a function with "Invoke"
        /* parameters == name of a function as a string,
         * the delay in seconds to wait before calling the function.
         */
        Invoke("PrintHey", 3);

        // you can call a function repeatedly with "InvokeRepeating"
        /* parameters == name of a function as a string,
         * the delay in seconds to wait before calling the function the first time
         * the delay between calls after first one.
         */
        InvokeRepeating("PrintHey", 2, 1);

        /* an empty CancelInvoke() cancels all functions
         * being called with Invoke and InvokeRepeating
         */
        CancelInvoke();


        /* CancelInvoke() with a method argument as a string
         * cancels the function.
         */
        CancelInvoke("PrintHey");


    }

    /* only functions that return nothing
     * and have no parameters
     * can be called using Invoke!!!
     */
    void PrintHey()
    {
        Debug.Log("hey");
    }

}
