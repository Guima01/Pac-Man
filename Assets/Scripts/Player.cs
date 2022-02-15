using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 40f;
    public int cheese = 0;
    void Start()
    {

    }

    void Update(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if(cheese == 4){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag == "Enemy"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(other.gameObject.tag == "Cheese"){
            SoundManagerScript.PlaySound("Cheese");
            cheese += 1; 
            Destroy(other.gameObject);
        }
    }
}
