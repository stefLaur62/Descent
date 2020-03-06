using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy1NavMesh : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;

    }
    private void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (agent.pathStatus != NavMeshPathStatus.PathComplete)
        {
            agent.isStopped=true;
        } else
        {
            agent.isStopped=false;
        }
        float dist = Vector3.Distance(agent.transform.position, goal.position);
        if (dist < 5)
        {
            agent.destination = agent.transform.position;
        }
        else
        {
            agent.destination = goal.position;
        }
        transform.LookAt(goal);
    }

}
