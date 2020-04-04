using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {

    public float healValue = 20.0f;
    public Health health;

   

	// Use this for initialization
	void Start () {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health> ();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //print("Hello");
        if (other.gameObject.tag == "Player")
        {
            if (health.currentHealth > 80)
            {
                health.currentHealth = 100;
                print(health.currentHealth);
            }
            else
            {
                health.currentHealth += healValue;
                print(health.currentHealth);
            }
            Destroy(this.gameObject);
        }
    }

}
