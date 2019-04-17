using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    private NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemyVision.playerDetect)
        {
            nav.destination = enemyVision.lastSighting;
        }
        Debug.DrawLine(transform.position, enemyVision.lastSighting, Color.green);
    }
}
