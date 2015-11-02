using UnityEngine;
using System.Collections;

public class JamesReaction : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void JamesHouseDestroy(){
		GetComponentInParent<NPCJames> ().dialogueChange = true;
	}
}
