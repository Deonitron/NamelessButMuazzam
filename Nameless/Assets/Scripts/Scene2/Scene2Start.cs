using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Start : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        StartCoroutine(Starter());
    }

    IEnumerator Starter()
    {
        yield return new WaitForSeconds(.2f);
        player.GetComponent<PrototypeHeroDemo>().enabled = true;

        player.GetComponentInChildren<Changingform>().entered = true;

        GameObject.FindGameObjectWithTag("Spirit").SetActive(false);
    }
}
