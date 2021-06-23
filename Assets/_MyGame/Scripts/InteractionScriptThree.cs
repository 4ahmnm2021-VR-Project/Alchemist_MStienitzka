using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScriptThree : MonoBehaviour
{
    public GameObject player;
    public GameObject newCords;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "intro_bottle_full")
        {
            player.transform.position = newCords.transform.position;
        }
    }
}