using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player") {
			if(Application.loadedLevel == 0){
				Application.LoadLevel (1);
			}

			else if(Application.loadedLevel == 1){
				Application.LoadLevel (2);
			}

			else if(Application.loadedLevel == 2){
				Application.LoadLevel (3);
			}
		}
	}
}
