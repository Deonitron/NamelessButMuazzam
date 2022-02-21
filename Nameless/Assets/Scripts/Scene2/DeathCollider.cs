using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            collision.transform.position = collision.gameObject.GetComponent<CheckPointManager>().checkPoint.transform.position;
        }

        if (collision.gameObject.CompareTag("Spirit"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            collision.transform.position = collision.gameObject.GetComponent<CheckPointManager>().checkPoint.transform.position;
        }
    }
}
