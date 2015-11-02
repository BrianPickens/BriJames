﻿using UnityEngine;
using System.Collections;

public class SwampWormSearch : MonoBehaviour {



	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Player") {
			transform.parent.GetComponent<SwampWorm>().SetScreamOn();
			
		}
		
	}

	void OnTriggerExit(Collider other){

	if(other.gameObject.tag == "Player"){
		transform.parent.GetComponent<SwampWorm>().SetScreamOff();
	}

	}
}
