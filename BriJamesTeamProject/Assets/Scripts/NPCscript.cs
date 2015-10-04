using UnityEngine;
using System.Collections;

public class NPCscript : MonoBehaviour {

	public GameObject Dialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player") {
			Debug.Log ("enter");
			Dialogue.SetActive (true);
		}
	}

}
