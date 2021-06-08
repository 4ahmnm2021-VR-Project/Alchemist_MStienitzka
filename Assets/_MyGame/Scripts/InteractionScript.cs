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

    private void Awake()
    {
        stoarge.cauldronReady = false;
        stoarge.cauldronNotReady = false;
        stoarge.cauldrenWrong = false;
    }

    private void OnTriggerEnter(Collider col)
    {
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

        if (col.gameObject.tag == "noIngredient")
        {
            stoarge.cauldrenWrong = true;
            stoarge.cauldronNotReady = false;
            stoarge.cauldronReady = false;
        }
    }
}