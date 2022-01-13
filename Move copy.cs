using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float x = 0.0f;
    public float y = 0.0003f;
    public float z = 0.0f;
    public float scalingFactor = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x,y,z);
        //transform.localScale = new Vector3(1f,1f,1f);
		transform.localScale = new Vector3(transform.localScale.x+transform.localScale.x*scalingFactor*Time.deltaTime, transform.localScale.y+transform.localScale.y*scalingFactor * Time.deltaTime, transform.localScale.z+transform.localScale.z*scalingFactor * Time.deltaTime);
    }
}
