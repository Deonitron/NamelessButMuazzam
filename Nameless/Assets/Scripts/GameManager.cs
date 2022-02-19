using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float x1;
    float y1;
    Vector2 Vector31;
    void Start()
    {
        Vector31 = new Vector2(x1, y1);

            
    }

    void Update()
    {
        Camera.main.transform.position = Vector31;

        x1 += 0.01f;
    }
}
