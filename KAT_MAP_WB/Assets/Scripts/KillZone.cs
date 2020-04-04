using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour {

    
    private GameMaster gm;
    
    public Health health;
    private Transform PlayerTransform;
    //private CharacterController cc = Player.GetComponent<CharacterController>();
    //public Player player;

    // Use this for initialization
    void Start () {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //hurt the player and teleport them to last checkpoint
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            health.takeDamage();
            //health.currentHealth -= hurtValue;
            //print(health.currentHealth);
            //cc.enabled = false;
            //other.transform.position = gm.lastCheckpointPos;
            //cc.enabled = true;
        }
    }
}
