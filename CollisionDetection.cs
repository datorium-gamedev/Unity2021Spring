using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    MovementScript playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = gameObject.GetComponent<MovementScript>();
      
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("I Touched the ground");

            playerMovement.onGround = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("I am on the ground still here");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("I left the building yayyyy");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I ENTERED THE TRIGGER");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("I AM ON THE TRIGGER");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("I LEFT THE TRIGGER");
    }
}
