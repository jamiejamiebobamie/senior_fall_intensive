using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public string hitTag;
    Vector3 fwd;
    RaycastHit hit;


    public GameObject rayCastFrom;
    int count;
    int win = 300;

    void FixedUpdate()
    {
        hitTag = null;
        fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(rayCastFrom.transform.position, fwd, out hit, 100))
        {
        if (hit.transform.tag != hitTag)
            {
                hitTag = hit.transform.tag;
                Debug.Log(hitTag); // check for a tag

            }
            if (hit.transform.tag == "Player" && count < win)
            {
                Debug.Log(count);
                count++;
            } else if (count >= win) {
                Debug.Log("You won!");
            }
        }
    }
}