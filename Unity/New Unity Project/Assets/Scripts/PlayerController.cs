using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Projectile
    //Movement
    public float Speed;
    public float TurnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Position(Vector3(0,0,0));
        transform.Translate(Vector3.forward * Speed);
    }
}
