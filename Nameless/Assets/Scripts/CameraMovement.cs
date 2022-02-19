using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    Vector3 v3d;

    void Start()
    {
       
    }

    

    
    void Update()
    {
      
            v3d = new Vector3(GameObject.Find("PlaceHolder").transform.position.x, -1.07f, -6.5f);

            Camera.main.transform.position = v3d;
            
        
    }
}
