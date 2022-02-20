using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueMenager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    private Queue<string> sentences;
    public Animator animator;

    void Start()
    {
        sentences = new Queue<string>();

        
    }
    public void  StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;

        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;   
    }

    void EndDialogue()
    {
        
        animator.SetBool("IsOpen", false);
    }
    
}
