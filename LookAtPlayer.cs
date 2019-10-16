using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        //var rotation = Quaternion.LookRotation(target.transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
    }
}
