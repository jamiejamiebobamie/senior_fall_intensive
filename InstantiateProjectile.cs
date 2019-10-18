using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;
    public GameObject cameraRot;
    bool fire = false;

    // Update is called once per frame
    void Update()
    {
        fire = false;

        if (Input.GetKeyDown(KeyCode.F))
        {
            fire = true;
        }

        if(fire)
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, transform.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.forward * 1350f);
        }

        }
    }
