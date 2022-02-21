using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject box;

    public float xValue;
    public float yValue;

    private bool hasActivated;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasActivated)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            box.transform.position = new Vector3(box.transform.position.x + xValue, box.transform.position.y + yValue, box.transform.position.z);

            hasActivated = true;
        }
    }
}
