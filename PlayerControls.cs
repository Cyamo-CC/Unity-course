using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float thrustSpeed;
    public float turnSpeed;

    private float thrustInput;
    private float turnInput;
    private Rigidbody shipRigidBody;


    // Use this for initialization
    void Start()
     {
            shipRigidBody = GetComponent<Rigidbody>();
     }

    // Update is called once per frame
    void Update()
    {
        thrustInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

        // Turning the ship
        shipRigidBody.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);

        // Moving the ship
        shipRigidBody.AddRelativeForce(0f, 0f, thrustInput * thrustSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            thrustSpeed = thrustSpeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            thrustSpeed = thrustSpeed / 2;
        }
    }

    void fixedUpdate()
    {

       
    }
    void OnTriggerEnter(Collider triggerCollider)
    {
        
    }
      
}