using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

// Declare Variables, GameObjects, Etc...-----------------------------------------------------

    public float speed = 50.0f;
    public float turnSpeed = 100.0f;
    public float hInput;
    public float vInput;
    
    public float xRange = 7.7f;
    public float yRange = 4.5f;

    public GameObject projectile;
    private Vector3 offset = new Vector3(0,2,0);

// -------------------------------------------------------------------------------------------
void Update()
    {
// -------------------------------------------------------------------------------------------
    
    //Declare Horizontal and Vertical Inputs
    
            hInput = Input.GetAxis("Horizontal");
            vInput = Input.GetAxis("Vertical");

// Movement-----------------------------------------------------------------------------------

    //Makes the Player rotate left and right
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * hInput);
    // Makes the Player move forward and back    
        transform.Translate(Vector3.up * speed * Time.deltaTime * vInput);

// Borders------------------------------------------------------------------------------------

    //Right wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    //Left Wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    //Top Wall
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
    //Bottom Wall
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

// Spawn Projectile----------------------------------------------------------------------------

    if(Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(projectile, transform.position, projectile.transform.rotation);
    }



    }
}
