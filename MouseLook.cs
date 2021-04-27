using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public int mouseSensitivity = 300;
    private float xClamp;
    public Camera myCamera;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        gameObject.GetComponent<Transform>().Rotate(Vector3.up * MouseX);
        xClamp = Mathf.Clamp(xClamp - MouseY, -90, 90);
        myCamera.transform.eulerAngles = new Vector3(xClamp, myCamera.transform.eulerAngles.y, myCamera.transform.eulerAngles.z);

    }
}
