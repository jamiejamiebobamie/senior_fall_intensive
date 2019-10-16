using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;
    public GameObject cameraRot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, cameraRot.transform.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.up * 350f);
        }
    }
}
