using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfWDelay : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
     Destroy(gameObject, 7f);   
    }
}
