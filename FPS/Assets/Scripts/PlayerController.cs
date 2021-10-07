using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//Movement
    public float moveSpeed;
    public float jumpForce;
//Camera
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;

    private Camera cam;
    private Rigidbody rig;

    private Weapon weapon;


    void Awake() 
    {
    //get components
        weapon = GetComponent<Weapon>();
        cam = Camera.main;
        rig = GetComponent<Rigidbody>();
        //disable cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            if(weapon.CanShoot())
                weapon.Shoot();
        }
        if(Input.GetButtonDown("Jump"))
        {
        TryJump();
        }
        Move();
        CamLook();
    }
        void TryJump()
        {
            Ray ray = new Ray(transform.position, Vector3.down);

            if(Physics.Raycast(ray, 1.1f))
                rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        void CamLook()
        {
            float y = Input.GetAxis("Mouse X") * lookSensitivity;
            rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
        //"Clamp" vertical rotation
            rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
        //Apply Rotation
            cam.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
            transform.eulerAngles += Vector3.up * y;
        }

        void Move() 
        {
            float x = Input.GetAxis("Horizontal") * moveSpeed;
            float z = Input.GetAxis("Vertical") * moveSpeed;
            
            Vector3 dir = transform.right * x + transform.forward * z;
            dir.y = rig.velocity.y;

            rig.velocity = dir;
            //rig.velocity = new Vector3(x, rig.velocity.y, z)
        }
    
}