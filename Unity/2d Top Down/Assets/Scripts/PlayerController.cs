using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;
    public float turnSpeed = 10.0f;
    public float hInput;
    public float vInput;
  
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

    //Makes the Player rotate left and right
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * hInput);
    // Makes the Player move forward and back    
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * vInput);





    }
}
