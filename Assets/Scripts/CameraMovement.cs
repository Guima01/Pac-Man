using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{


    public Transform playerBody;
    public float mouseSens = 5.0f;

    float xRotation = 0f;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
        float mouseX = Input.GetAxis("Mouse X") * mouseSens;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    // void Start()
    // {
    //     playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    //     transform.position = playerTransform.position;    
    // }

    // void LateUpdate()
    // {
    //     Vector3 temp = playerTransform.position;
    //     transform.position = temp;

    //     horizontal += speedRotation * Input.GetAxis("Mouse X");
    //     // vertical += speedRotation * Input.GetAxis("Mouse Y");

    //     transform.eulerAngles = new Vector3(0.0f, horizontal , 0.0f);
    // }
}