using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScriptThree : MonoBehaviour
{
    public GameObject player;
    public GameObject newCords;
    public ParticleSystem roatator;

    private IEnumerator Intro()
    {
        roatator.Play();
        yield return new WaitForSeconds(8f);
        player.transform.position = newCords.transform.position;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "intro_bottle_full")
        {
            StartCoroutine(Intro());
        }
    }
}