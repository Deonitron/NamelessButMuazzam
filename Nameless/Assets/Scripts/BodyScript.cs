using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyScript : MonoBehaviour
{
   public bool life= false;
   
    
    void Start()
    {
        
    }

    
    void Update()
    {
    }

    public void Death()
    {

        StartCoroutine(waiter());

    }

    IEnumerator waiter()
    {
        for (int i = 0; i < 5; i++)
        {

            GetComponent<SpriteRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            GetComponent<SpriteRenderer>().material.color = Color.white;
            yield return new WaitForSeconds(0.1f);

           


        }

        GetComponentInChildren<Changingform>().Outer();
        gameObject.SetActive(false);
        
    }

}
