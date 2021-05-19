using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    public GameObject levítationObject;
    public AnimationCurve myCurve;

    void Update()
    {
        levítationObject.transform.position = new Vector3(levítationObject.transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), levítationObject.transform.position.z);
    }
}
 