using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50.0f;
    public float turnSpeed = 100.0f;
    public float hInput;
    public float vInput;
  
  public float xRange = 7.7f;
  public float yRange = 4.5f;
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

    //Makes the Player rotate left and right
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * hInput);
    // Makes the Player move forward and back    
        transform.Translate(Vector3.up * speed * Time.deltaTime * vInput);

    if (transform.position.x > xRange)
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }
    if (transform.position.x < -xRange)
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    if (transform.position.y > yRange)
    {
        transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
    }
    if (transform.position.y < -yRange)
    {
        transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
    }



    }
}
