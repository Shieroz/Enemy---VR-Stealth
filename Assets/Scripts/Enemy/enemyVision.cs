using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyVision : MonoBehaviour
{
    public static bool playerDetect;        //Tag for when player is detected
    public static Vector3 lastSighting;     //last sighting of the player
    public float fieldOfView;               //Enemy's field of view angle (cone shape)
    public float visionRange;               //Max vision range

    SphereCollider vision;
    
    private GameObject player;              //Reference to the player's child gameObject Detection

    // Start is called before the first frame update
    void Start()
    {
        playerDetect = false;
        vision = GetComponent<SphereCollider>();
        vision.radius = visionRange;
        player = GameObject.FindGameObjectWithTag("Player").transform.Find("Detection").gameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);

            if (angle < fieldOfView * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position, direction.normalized, out hit, vision.radius))
                {
                    if (hit.collider.gameObject == player)
                    {
                        playerDetect = true;
                        lastSighting = player.transform.position;
                        Debug.DrawLine(transform.position, other.transform.position, Color.red);
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            playerDetect = false;
    }
}
