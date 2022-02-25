using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class Player : MonoBehaviour
{

    public CharacterController controller;
    public float speed;
    public int cheese = 0;
    private float timer = 0.0f;
    private bool special = false;

    void Start()
    {

    }

    void Update(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if(cheese == 4){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        if(RecalculateValue() && special == true){
            speed = 12f;
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
        if(other.gameObject.tag == "Buff"){
            timer = 0;
            special = true;
            SoundManagerScript.PlaySound("Potion");
            speed = 60f; 
            Destroy(other.gameObject);
        }
    }

    public bool RecalculateValue()
    {
        timer += Time.deltaTime;
        if(timer >= 7.0f){
            return true;
        }
        return false;
    }
}
