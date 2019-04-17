using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float offset;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = player.transform.position + Vector3.up * offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + Vector3.up * offset;
    }
}
