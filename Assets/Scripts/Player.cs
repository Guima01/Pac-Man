using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float speedRotation = 2.0f;
    private float horizontal = 0.0f;

    void Start()
    {

    }

    void Update(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // horizontal += speedRotation * Input.GetAxis("Mouse X");
        // transform.Rotate(new Vector3(0.0f, horizontal, 0.0f) * Time.deltaTime * 3, Space.World);

        controller.Move(move * speed * Time.deltaTime);
    }
    // private Rigidbody rb;
    // private float xForce;
    // private float zForce;
    // private Vector3 force;
    // private float pitch =0.0F;
    // private float yaw =0.0F;

    // public float speedRotation = 2.0f;
    // private float horizontal = 0.0f;
    // private float aimSpeed;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     // Vector3 horizontalMov = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    //     // transform.position = transform.position + horizontalMov * Time.deltaTime * 8;
    //     // horizontal += speedRotation * Input.GetAxis("Mouse X");
    //     // transform.Rotate(new Vector3(0.0f, horizontal, 0.0f) * Time.deltaTime * 3, Space.World);
    // }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy"){
            Destroy(gameObject);
        }
    }
}
