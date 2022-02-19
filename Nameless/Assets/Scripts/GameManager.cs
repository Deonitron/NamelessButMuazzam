using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float x1;
    Vector3 Vector31;
    void Start()
    {

            
    }

    void Update()
    {
        Vector31 = new Vector3(x1, Camera.main.transform.position.y, Camera.main.transform.position.y);
        Vector31 = new Vector3(x1, Camera.main.transform.position.y, Camera.main.transform.position.z);
=========
        Vector31 = new Vector3(x1, Camera.main.transform.position.y,-5);
>>>>>>>>> Temporary merge branch 2

        Camera.main.transform.position = Vector31;

        x1 += 0.01f;
    }
}
