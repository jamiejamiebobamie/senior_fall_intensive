using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLightWDelay : MonoBehaviour
{

    public Light myLight;

    float countdown = 5.0f;
    bool countdownInitialized = false;

    // Start is called before the first frame update
    void Start()
    {
        //myLight = GetComponent<GameObject>();

      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            countdownInitialized = true;
        }

        if (countdownInitialized)
        {
            countdown -= Time.deltaTime;
            //Debug.Log(countdown);
        }

        if (countdown <= 0.0f)
        {
            //Debug.Log(myLight.enabled);

            myLight.enabled = false;
        }
        
    }
}
