using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{




    public Dialogue dialogue;
    bool startedDialogue= false;



    private void Update()
    {
        if (startedDialogue && Input.GetKeyDown(KeyCode.O))
        {
            FindObjectOfType<DialogueMenager>().DisplayNextSentence();
        }
    }



    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueMenager>().StartDialogue(dialogue);
        startedDialogue = true;
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if(collision.CompareTag("spiritHolder")&& !startedDialogue)
        {
            TriggerDialogue();
        }



    }

 
}
