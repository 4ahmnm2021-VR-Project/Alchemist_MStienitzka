using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualChange : MonoBehaviour
{
    public Data storage;
    public MeshRenderer substance;
    public Material finished;
    public Material notfinished;
    public Material wrong;
    public GameObject Particle;

    void Update()
    {
        if (storage.cauldronReady)
        {
            substance.material = finished;
        }
        else if (storage.cauldronNotReady)
        {
            substance.material = notfinished;
        }
        else if (storage.cauldrenWrong)
        {
            substance.material = wrong;
        }

        if (storage.cauldronReady)
        {
            Particle.SetActive(true);
        }
    }
}
