using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeRangeDetection : MonoBehaviour
{
    SphereCollider detect;
    public float detectionRange = 2f;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        detect = GetComponent<SphereCollider>();
        detect.radius = detectionRange;
        player = GameObject.FindGameObjectWithTag("Player").transform.Find("Detection").gameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            enemyVision.playerDetect = true;
            enemyVision.lastSighting = player.transform.position;
            Debug.DrawLine(transform.position, player.transform.position, Color.blue);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            enemyVision.playerDetect = false;
    }
}
