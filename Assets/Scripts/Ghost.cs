using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour {

    public GameObject target;   //this is the player or a reference for him
    UnityEngine.AI.NavMeshAgent agent;         //this is a reference for the ghost navmeshagent component

	// Use this for initialization
	void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.speed = 10.0f;
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        agent.destination = target.transform.position ;
	}
}