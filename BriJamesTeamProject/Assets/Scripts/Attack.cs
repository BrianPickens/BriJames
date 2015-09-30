﻿using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
			other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Enemy>().dead = true;
			other.gameObject.GetComponent<Enemy>().deadAnim = false;
           // Destroy(other.gameObject);
        }

		if (other.gameObject.tag == "Explodable") {
			other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Reactive>().aSplode = true;

		}
    }
}
