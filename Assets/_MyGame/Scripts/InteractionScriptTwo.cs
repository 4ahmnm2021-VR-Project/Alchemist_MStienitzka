using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScriptTwo : MonoBehaviour
{
    public bool stateOne;
    public bool bottleFilled;
    public GameObject bottle;

    private void Awake()
    {
        stateOne = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "intro_part")
        {
            if (!stateOne)
            {
                stateOne = true;
            }
        }

        if (col.gameObject.tag == "intro_bottle_empty")
        {
            if (stateOne)
            {
                bottle.transform.tag = "intro_bottle_full";
            }
        }
    }
}