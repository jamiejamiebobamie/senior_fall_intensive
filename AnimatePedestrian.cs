using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimatePedestrian : MonoBehaviour
{

    Animator anim;

    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;
    [SerializeField] private GameObject object3;
    [SerializeField] private GameObject[] objects;

    float dist = 3;

    [SerializeField] private NavMeshAgent m_navMeshAgent;
    [SerializeField] private GameObject m_Target;

    bool doOnce = true;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        objects = new [] { object1, object2, object3 };
        m_Target = objects[0];
        Debug.Log(objects);
    }

    void switchState()
    {
        if (dist < Vector3.Distance(m_Target.transform.position, transform.position))
        {
            m_navMeshAgent.SetDestination(m_Target.transform.position);
            if (doOnce)
            {
                anim.SetBool("Walking", true);
                anim.SetBool("Idle", false);
                doOnce = false;
            }
        }
        else
        {
            System.Random r = new System.Random();
            int rInt = r.Next(0, 3); //for ints
            m_Target = objects[rInt];
            Debug.Log(m_Target.name);

            if (!doOnce)
            {
                anim.SetBool("Walking", false);
                anim.SetBool("Idle", true);
                doOnce = true;
            }

        }
    }


    private void FixedUpdate()
    {
        switchState();
    }
}