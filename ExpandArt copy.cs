using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandArt : MonoBehaviour
{
    private bool coroutineAllowed;
    
    public Vector3 targetPosition;
    public float smoothTime = 0.7f;
    public float smooth = 5.0f;
    public float tiltAngle = -80.0f;
    private float movementSpeed = 400;
    Vector3 velocity;

    //start is called
    void Start()
    {
        coroutineAllowed = true;
    }

    public float scaleBy;
    public Transform artworkTrans;

    //void Update() {
        private void OnMouseDown()
        {
            if (coroutineAllowed)
            {
            //get the Input from Horizontal axis
            //float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            //float verticalInput = Input.GetAxis("Vertical");
            //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

            Quaternion target = Quaternion.Euler(10, 30, 10);

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
           //for (int i = 1; i<10; i++){
            //artworkTrans.transform.position += new Vector3(0.1f, 0f, -0.1f);
            //}
            //artworkTrans.transform.localScale += new Vector3(1.1f, 1.1f, 1.1f);
            //transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
            Debug.Log("Detects Mouse Button Down"); 
            coroutineAllowed = false;
            }

            // else
            // {
            // transform.position = Vector3.MoveTowards(targetPosition, transform.position, movementSpeed * Time.deltaTime);
            // coroutineAllowed = true;
            // }
        }
    //}
}
