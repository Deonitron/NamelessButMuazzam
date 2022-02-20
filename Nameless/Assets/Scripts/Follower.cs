using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    Transform spirit;
    
    void Start()
    {
        spirit = GameObject.FindGameObjectWithTag("spiritHolder").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,spirit.position)>15)
        {
            transform.Translate(new Vector3(1, 0, 0));
        }
    }
}
