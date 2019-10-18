using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject staticProjectile;
    RaycastHit hit;

    private void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity);

        if (hit.distance < 1 && hit.transform.tag == "Shootable")
        {
            Debug.Log("Hit");
            Quaternion storedRot = gameObject.transform.rotation;
            Destroy(gameObject);
            GameObject projectileInstance;
            projectileInstance = Instantiate(staticProjectile, hit.point, storedRot);
        }
    }
}
