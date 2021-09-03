using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Projectile
    //Movement
    public float Speed;
    public float TurnSpeed;
    public float hInput;
    public float vInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
    
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * vInput);
        transform.Rotate(Vector3.up * TurnSpeed * hInput * Time.deltaTime );
    }
}
