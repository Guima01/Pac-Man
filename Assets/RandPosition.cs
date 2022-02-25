using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandPosition : MonoBehaviour
{
    int x;
    int z;
    // Start is called before the first frame update
    void Start()
    {
        var rand = new System.Random();
        var rand2 = new System.Random();
        x = rand.Next(-20, 73);
        z = rand2.Next(-97, -5);
        transform.position = new Vector3(x, -9.30f, z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
