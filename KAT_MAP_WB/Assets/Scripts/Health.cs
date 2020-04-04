using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Health : MonoBehaviour {

    public GameObject player;
    private GameMaster gm;
    private Transform PlayerTransform;
    public float HealthAmount = 100.0f;
    public float currentHealth = 80.0f;
    public bool dead = false;
    public Vector3 startCheckpoint;
    public float hurtValue = 20.0f;
    private CharacterController cc;

    // Use this for initialization
    void Start () {
        cc = player.GetComponent<CharacterController>();
        PlayerTransform = GameObject.Find("Player").transform;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckpointPos;
    }
	
	// Update is called once per frame
	void Update () {
        //print(currentHealth);
        if (currentHealth <= 0)
        {
            //Destroy(this.gameObject);
            dead = true;
            gm.lastCheckpointPos = startCheckpoint;
            //PlayerTransform.position = currentCheckpoint;
            cc.enabled = false;
            transform.position = gm.lastCheckpointPos;
            cc.enabled = true;
            dead = false;
            currentHealth = HealthAmount;
        }
	}

    public void takeDamage()
    {
        currentHealth -= hurtValue;
        print(currentHealth);
        cc.enabled = false;
        transform.position = gm.lastCheckpointPos;
        cc.enabled = true;
    }

}
