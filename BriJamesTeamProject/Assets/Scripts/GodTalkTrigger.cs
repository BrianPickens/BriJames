using UnityEngine;
using System.Collections;

public class GodTalkTrigger : MonoBehaviour {

	public GameObject GodsVoice;
	public bool god1;
	public bool god2;
	public bool god3;
	public bool god4;
	public bool god5;
	public bool god6;
	public bool god7;
	public bool fearTheLedge;
	public bool godgoodbye;
	public bool godOff;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
		
			if (god1) {
				GodsVoice.GetComponent<GodDialogue> ().God1 ();
			} else if (god2) {
				GodsVoice.GetComponent<GodDialogue> ().God2 ();
			} else if (god3) {
				GodsVoice.GetComponent<GodDialogue> ().God3 ();
			} else if (god4) {
				GodsVoice.GetComponent<GodDialogue> ().God4 ();
			} else if (god5) {
				GodsVoice.GetComponent<GodDialogue> ().God5 ();
			} else if (god6) {
				GodsVoice.GetComponent<GodDialogue> ().God6 ();
			} else if (god7) {
				GodsVoice.GetComponent<GodDialogue> ().God7 ();
			} else if (fearTheLedge){
				GodsVoice.GetComponent<GodDialogue> ().FearTheLedge();
			} else if (godgoodbye){
				GodsVoice.GetComponent<GodDialogue> ().GodFarewell();
			} else if (godOff){
				GodsVoice.GetComponent<GodDialogue> ().EndGod ();
			}

		}
	}
}
