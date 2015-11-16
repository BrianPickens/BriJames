using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GodDialogue : MonoBehaviour {

	public GameObject DialogueBox;
	public Text GodTalk;
	public AudioClip TalkSound;

	// Use this for initialization
	void Start () {
	
		DialogueBox.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void God1(){
		DialogueBox.SetActive (true);
		GodTalk.text = "Fear not the fall, it brings you to those who need help.";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void God2(){
		DialogueBox.SetActive (true);
		GodTalk.text = "First you must learn how to help.";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void God3(){
		GodTalk.text = "Fear not the wall, use your powers to move obstacles. (HOLD X)";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void God4(){
		DialogueBox.SetActive (true);
		GodTalk.text = "Fear not the skyworms, for they wiggle in funny ways.";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void God5(){
		DialogueBox.SetActive (true);
		GodTalk.text = "Fear the swampworms, for they are annoying and don’t belong in the sky.";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void God6(){
		DialogueBox.SetActive (true);
		GodTalk.text = "Find the gate to fall to the land and serve the village in need.";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void God7(){
		DialogueBox.SetActive (true);
		GodTalk.fontSize = 22;
		GodTalk.text = "My child, you should have followed the path; no matter, fall through the gate, find the village, and serve those in need.";
		GetComponent<AudioSource> ().PlayOneShot (TalkSound);
	}

	public void EndGod(){
		DialogueBox.SetActive (false);
	}
}
