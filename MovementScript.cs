using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public int playerSpeed = 1;
    private float turnSpeed = 1.53453453453450f;
    protected bool canMove = false;

    public Rigidbody myRigid;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * playerSpeed;
        float verticalInput = Input.GetAxis("Vertical") * playerSpeed;

        Vector3 forwardMovement = gameObject.transform.forward * verticalInput * Time.deltaTime;
        Vector3 strifeMovement = gameObject.transform.right * horizontalInput * Time.deltaTime;

        gameObject.transform.Translate(forwardMovement);
        gameObject.transform.Translate(strifeMovement);
        

    }
}
