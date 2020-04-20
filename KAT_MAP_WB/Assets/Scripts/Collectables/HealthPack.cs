using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {

    public float healValue = 20.0f;
    public Health health;
    public Healthbar healthBar;
   

	// Use this for initialization
	void Start () {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health> ();
    }

    void OnTriggerEnter(Collider other)
    {
        //print("Hello");
        if (other.gameObject.tag == "Player")
        {
            if (health.currentHealth > 80)
            {
                health.currentHealth = 100;
                healthBar.SetHealth(health.currentHealth);
                print(health.currentHealth);
            }
            else
            {
                health.currentHealth += healValue;
                healthBar.SetHealth(health.currentHealth);
                print(health.currentHealth);
            }
            Destroy(this.gameObject);
        }
    }

}
