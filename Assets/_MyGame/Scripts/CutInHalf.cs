using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInHalf : MonoBehaviour
{
    public GameObject obj;
    public GameObject objcut1;
    public GameObject objcut2;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Knife")
        {
            objcut1.SetActive(true);
            objcut2.SetActive(true);
            obj.SetActive(false);
        }
    }
}