using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public int mouseSensitivity = 300;
    private float xClamp;
    public Camera myCamera;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        gameObject.GetComponent<Transform>().Rotate(Vector3.up * mouseX);
        xClamp = Mathf.Clamp(xClamp - mouseY, -90, 90);
        myCamera.transform.eulerAngles = new Vector3(xClamp, myCamera.transform.eulerAngles.y, myCamera.transform.eulerAngles.z);
    }
}
