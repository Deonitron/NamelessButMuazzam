using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody2D _r2d;

    float x;
    float y;
    public float speed;
   Vector2 speedForce;

    void Start()
    {
        _r2d = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        speedForce = Vector2.one * Time.deltaTime * speed;


        if (Input.GetKey(KeyCode.D))
        {
            if(_r2d.velocity.x < 2)
            {
                _r2d.AddForce(Vector2.right*Time.deltaTime*speed);
            }
        }
        else 
        {
            if(_r2d.velocity.x>0.01)
            {
                _r2d.AddForce(Vector2.left * Time.deltaTime * speed);
            }

        }

        if (Input.GetKey(KeyCode.A))
        {
            if (_r2d.velocity.x > -2)
            {
                _r2d.AddForce(Vector2.left * Time.deltaTime * speed);
            }
            
        }
        else
        {
            if(_r2d.velocity.x<-0.01)
            {
                _r2d.AddForce(Vector2.right * Time.deltaTime * speed);

            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (_r2d.velocity.y > -2)
            {
                _r2d.AddForce(Vector2.up * Time.deltaTime * speed);
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (_r2d.velocity.y > -2)
            {
                _r2d.AddForce(Vector2.down * Time.deltaTime * speed);
            }

        }




    }
}
