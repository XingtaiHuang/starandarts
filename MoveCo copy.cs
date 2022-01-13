using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCo : MonoBehaviour
{
    AudioSource audioData;
    public float scalingFactor = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MyCoroutine");
    }

    IEnumerator MyCoroutine()
    {
        int i= 10;
        int j= 1;
        while (i>0)
        {
            // Do something 100 times
            i--;
            j++;
            transform.Translate(0f,0.02f,0f,Camera.main.transform);
            transform.localScale = new Vector3(transform.localScale.x+transform.localScale.x*scalingFactor*j, transform.localScale.y+transform.localScale.y*scalingFactor * j, transform.localScale.z+transform.localScale.z*scalingFactor * j);
            yield return new WaitForSeconds(0.1F);
        }
            //audioData = GetComponent<AudioSource>();
        //audioData.Play(0);
        //yield return new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
