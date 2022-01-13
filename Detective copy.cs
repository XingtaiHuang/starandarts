using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class Detective : MonoBehaviour
{
    AudioSource audioData;
    // Start is called before the first frame update
    

    void Start()
    {
        StartCoroutine("MyCoroutine");
    }

    IEnumerator MyCoroutine()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        yield return new WaitForSeconds(1);
    }

}



