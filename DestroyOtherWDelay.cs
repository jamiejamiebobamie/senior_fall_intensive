using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOtherWDelay : MonoBehaviour
{

    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Destroy(target, 3f);
        } 
    }
}
