using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public int playerSpeed = 1;
    private float turnSpeed = 1.53453453453450f;
    public bool canMove = false;

    public bool onGround = true;
    public float YForce = 20f;

    public Rigidbody playerRigid;

// Update is called once per frame
void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * playerSpeed;
        float verticalInput = Input.GetAxis("Vertical") * playerSpeed;

        Vector3 forwardMovement = gameObject.transform.forward * verticalInput * Time.deltaTime;
        Vector3 strifeMovement = gameObject.transform.right * horizontalInput * Time.deltaTime;


        gameObject.transform.Translate(Vector3.right * verticalInput * playerSpeed * Time.deltaTime);
        gameObject.transform.Translate(Vector3.back * horizontalInput * playerSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && onGround == true)
        {
            playerRigid.AddForce(new Vector3(0, YForce, 0), ForceMode.Impulse);
            onGround = false;
        }



    }
}
