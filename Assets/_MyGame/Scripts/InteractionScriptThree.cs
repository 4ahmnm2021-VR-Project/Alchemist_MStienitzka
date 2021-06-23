using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScriptThree : MonoBehaviour
{
    public GameObject player;
    public GameObject newCords;
    public ParticleSystem roatator;

    private IEnumerator Wait()
    {
        roatator.Play();
        yield return new WaitForSeconds(8f);
        player.transform.position = newCords.transform.position;
    }

    private void OnTriggerEnter(Collider col)
    {
        StartCoroutine(Wait());
    }
}