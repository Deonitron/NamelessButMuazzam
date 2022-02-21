using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public GameObject checkPoint;

    private GameObject spirit;

    private void Awake()
    {
        spirit = GameObject.FindGameObjectWithTag("Spirit");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckPoint"))
        {
            if (gameObject.CompareTag("Spirit"))
            {
                checkPoint = collision.gameObject;
            }
            else
            {
                checkPoint = collision.gameObject;
                spirit.GetComponent<CheckPointManager>().checkPoint = collision.gameObject;
            }
        }
    }
}
