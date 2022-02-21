using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2 : MonoBehaviour
{

    public GameObject spiritHolder;
    public float camDistance;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(spiritHolder.transform.position.x, spiritHolder.transform.position.y + 0.5f, camDistance);
    }
}
