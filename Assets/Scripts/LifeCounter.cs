using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    private GameObject player;
    private GameObject text;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text = GameObject.FindGameObjectWithTag("CheeseNumber");
        text.GetComponent<UnityEngine.UI.Text>().text = (player.GetComponent<Player>().cheese).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if((player.GetComponent<Player>().cheese).ToString() != text.GetComponent<UnityEngine.UI.Text>().text){
            text.GetComponent<UnityEngine.UI.Text>().text = (player.GetComponent<Player>().cheese).ToString();
        }
    }
}
