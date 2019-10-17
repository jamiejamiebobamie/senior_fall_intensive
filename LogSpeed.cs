using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpeed : MonoBehaviour
{

    float time;
    float speed;
    Vector3 prevPos;

    private void Start()
    {
        time = Time.deltaTime;
        prevPos = Vector3.zero;
    }

    void FixedUpdate()
    {
        speed = (gameObject.transform.position - prevPos).magnitude;
        Debug.Log(speed);
        prevPos = gameObject.transform.position;
    }
}
