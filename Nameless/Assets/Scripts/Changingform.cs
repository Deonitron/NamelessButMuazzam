using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changingform : MonoBehaviour
{
    GameObject spirit;
    bool entered = false;
    public bool isFirst;

    void Start()
    {
        
        spirit = GameObject.FindGameObjectWithTag("Spirit");
        

        StartCoroutine(Disabler());
       

    }


    void Update()
    {
        if(entered && Input.GetKeyDown(KeyCode.Q))
        {
            Outer();
        }
        


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && collision.transform.CompareTag("spiritHolder"))
        {
            
            GetComponentInParent<Rigidbody2D>().mass = 1;

            collision.transform.SetParent(transform);

            spirit.gameObject.SetActive(false);

            GetComponentInParent<PrototypeHeroDemo>().enabled = true;
            entered = true;



        }
        
    }

    IEnumerator Disabler()
    {
        yield return new WaitForSeconds(0.01f);

        if(!isFirst)
        {
            GetComponentInParent<PrototypeHeroDemo>().enabled = false;

        }
        else 
        
        {
            
            spirit.gameObject.SetActive(false);
            GetComponentInParent<Rigidbody2D>().mass = 1;
            
        }
    }


    public void Outer()
    {
        
        
            GetComponentInParent<Rigidbody2D>().mass = 50;

            GetComponentInParent<PrototypeHeroDemo>().enabled = false;

            spirit.transform.position = transform.position;

            spirit.gameObject.SetActive(true);



           GameObject.FindGameObjectWithTag("spiritHolder").GetComponent<Transform>().SetParent(spirit.transform);

            entered = false;

           

        

    }

}
