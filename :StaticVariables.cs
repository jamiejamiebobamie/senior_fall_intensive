using UnityEngine;
using System.Collections;

public class StaticVariables : MonoBehaviour
{

	// static variables are variables that are shared across all members of a class.
	// you can also have static classes that cannot have instances of themselves.
	public static int numberOfObjectsThatContainThisScript = 0;

    // Use this for initialization
    void Start()
    {
		numberOfObjectsThatContainThisScript++;
    }
}


// access the variable using:
// StaticVariables.numberOfObjectsThatContainThisScript