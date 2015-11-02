using UnityEngine;
using System.Collections;

public class NPCSpeak1 : MonoBehaviour {

	public GameObject Dialogue;
	private bool dialogueOn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
//		if (other.gameObject.tag == "Player") {
//			dialogueOn = true;
//			Dialogue.GetComponent<DialogueManager>().Npc1();
//		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			dialogueOn = false;
			Dialogue.GetComponent<DialogueManager>().EndDialogue();
		}
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Player") {
			if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Return) || Input.GetButtonDown ("X") || Input.GetButtonDown ("MacX")) {
				if (dialogueOn) {
					Dialogue.GetComponent<DialogueManager> ().EndDialogue ();
					dialogueOn = false;
				} else if (!dialogueOn) {
					Dialogue.GetComponent<DialogueManager> ().Npc1 ();
					dialogueOn = true;
				}
			}
		}
	}
}
