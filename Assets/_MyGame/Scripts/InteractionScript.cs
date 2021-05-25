using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
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