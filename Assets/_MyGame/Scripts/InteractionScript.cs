using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    public Canvas can;
    public Text textstateOne;
    public Text textstateTwo;
    public Text textstateThree;
    public string newStateOne;
    public string newStateTwo;
    public string newStateThree;
    public bool stateOne;
    public bool stateTwo;
    public bool stateThree;
    public Data stoarge;
    public GameObject bottle;

    private void Awake()
    {
        stoarge.cauldronReady = false;
        stoarge.cauldronNotReady = false;
        stoarge.cauldrenWrong = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        //Main Interaction
        if (col.gameObject.tag == "IngredientOne")
        {
            if (!stateOne & !stateTwo & !stateThree)
            {
                stateOne = true;
                stoarge.cauldronNotReady = true;
                textstateOne.text = newStateOne;
            }
            else
            {
                stoarge.cauldrenWrong = true;
                stoarge.cauldronNotReady = false;
                stoarge.cauldronReady = false;
            }
        }
        if (col.gameObject.tag == "IngredientTwo")
        {
            if (stateOne & !stateTwo & !stateThree)
            {
                stateTwo = true;
                textstateTwo.text = newStateTwo;
            }
            else
            {
                stoarge.cauldrenWrong = true;
                stoarge.cauldronNotReady = false;
                stoarge.cauldronReady = false;
            }
        }
        if (col.gameObject.tag == "IngredientThree")
        {
            if (stateOne & stateTwo & !stateThree)
            {
                stateThree = true;
                stoarge.cauldronNotReady = false;
                stoarge.cauldronReady = true;
                textstateThree.text = newStateThree;
            }
            else
            {
                stoarge.cauldrenWrong = true;
                stoarge.cauldronNotReady = false;
                stoarge.cauldronReady = false;
            }
        }

        if (col.gameObject.tag == "intro_bottle_empty")
        {
            if (stateOne & stateTwo & stateThree)
            {
                bottle.transform.tag = "intro_bottle_full";
            }
        }

        if (col.gameObject.tag == "noIngredient")
        {
            stoarge.cauldrenWrong = true;
            stoarge.cauldronNotReady = false;
            stoarge.cauldronReady = false;
        }
    }
}