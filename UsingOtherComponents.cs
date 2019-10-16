using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityTemplateProjects;

public class UsingOtherComponents : MonoBehaviour
{

    public GameObject target;
    private LookAtPlayer otherObjectsScript;

    private void Awake()
    {
        /* GetComponent is programmatically very expensive and should
        *  only be called in the awake or start functions!
        */
        otherObjectsScript = target.GetComponent<LookAtPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            //Debug.Log(otherObjectsScript, target);
            Destroy(otherObjectsScript);
        }
        
    }
}
