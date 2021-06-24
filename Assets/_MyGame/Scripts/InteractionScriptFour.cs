using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractionScriptFour : MonoBehaviour
{
    public ParticleSystem roatator;

    private IEnumerator Intro()
    {
        roatator.Play();
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(+1);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "intro_bottle_full")
        {
            StartCoroutine(Intro());
        }
    }
}