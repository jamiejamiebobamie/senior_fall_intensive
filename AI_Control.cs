using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class AI_Control : MonoBehaviour
{

    [SerializeField] private NavMeshAgent m_navMeshAgent;
    [SerializeField] private GameObject m_Target;

    // Update is called once per frame
    void Update()
    {
        m_navMeshAgent.SetDestination(m_Target.transform.position);
    }
}
