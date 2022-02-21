using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueTrigger : MonoBehaviour
{
    public GameObject statue;
    public float speed;

    private Vector2 startPos;
    private bool startStatue;

    private void Start()
    {
        startPos = statue.transform.position;
    }

    private void Update()
    {
        if (startStatue)
        {
            if(statue.transform.position.x < startPos.x + 14)
            {
                statue.transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            }
            else if(statue.transform.position.x >= startPos.x + 14)
            {
                Destroy(statue);
                startStatue = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spirit"))
        {
            startStatue = true;
        }
    }
}
