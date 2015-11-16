using UnityEngine;
using System.Collections;

public class NPCHoward : MonoBehaviour {
	public GameObject Dialogue;
	private bool dialogueOn;
	private bool dialogueReady;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if (dialogueReady) {
//			if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Return) || Input.GetButtonDown ("X") || Input.GetButtonDown ("MacX")) {
//				if (dialogueOn) {
//					Dialogue.GetComponent<DialogueManager> ().EndDialogue ();
//					dialogueOn = false;
//				} else if (!dialogueOn) {
//					Dialogue.GetComponent<DialogueManager> ().Howard ();
//					dialogueOn = true;
//				}
//			}
//		}
	}
	
	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Player") {
			dialogueReady = true;
			Dialogue.GetComponent<DialogueManager> ().Howard ();
			dialogueOn = true;
		}
	}
	
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			dialogueReady = false;
			dialogueOn = false;
			Dialogue.GetComponent<DialogueManager>().EndDialogue();
		}
	}
	
	
}
