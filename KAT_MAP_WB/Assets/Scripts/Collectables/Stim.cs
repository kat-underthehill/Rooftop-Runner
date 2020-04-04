using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stim : MonoBehaviour {

    public float improvement = 50.0f;
    public PlayerMovement playermovement;

	// Use this for initialization
	void Start () {
        playermovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playermovement.runSpeed += 10.0f;
            Debug.Log(playermovement.runSpeed);
            Destroy(this.gameObject);
        }
    }
}
