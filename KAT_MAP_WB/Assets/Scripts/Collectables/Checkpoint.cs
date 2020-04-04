using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private Vector3 centerNormal;
    public Health health;
    public GameObject playerLoc;
    private Renderer rend;
    //public Transform TeleportGoal;
    private GameMaster gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        playerLoc = GameObject.FindGameObjectWithTag("Player");
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        rend = GetComponent<Renderer>();
        centerNormal = rend.bounds.center;
    }
	
	// Update is called once per frame
	void Update () {
        //if (health.dead == true)
        //{
            //health.currentHealth = health.HealthAmount;
            //health.dead = false;
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print(centerNormal);
            //TeleportGoal.position = centerNormal;
            gm.lastCheckpointPos = transform.position;
            //health.currentCheckpoint = TeleportGoal.position;
        }
    }

}
