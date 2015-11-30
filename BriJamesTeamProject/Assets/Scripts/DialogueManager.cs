using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
	
	public GameObject DialogueBox;
	public GameObject CharacterSprite;
	public Text CharacterText;


	public Sprite NPC1Sprite;
	public Sprite JamesSprite;
	public Sprite BrianSprite;

	public AudioClip NPC1Voice;
	public AudioClip JamesVoice;
	public AudioClip BrianVoice;
	

	// Use this for initialization
	void Start () {
		DialogueBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Npc1(){
		DialogueBox.SetActive (true);
		CharacterText.text = "I'm too afraid to make the jump!";
		CharacterSprite.GetComponent<Image> ().sprite = NPC1Sprite;
		GetComponent<AudioSource> ().PlayOneShot (NPC1Voice);
	}

	public void James(){
		DialogueBox.SetActive (true);
		CharacterText.text = "I love my home so much!";
		CharacterSprite.GetComponent<Image> ().sprite = JamesSprite;
		GetComponent<AudioSource> ().PlayOneShot (JamesVoice);
	}

	public void JamesAngry(){
		DialogueBox.SetActive (true);
		CharacterText.text = "I loved my home. Now I love my rubble.";
		CharacterSprite.GetComponent<Image> ().sprite = JamesSprite;
		GetComponent<AudioSource> ().PlayOneShot (JamesVoice);
	}

	public void Brian(){
		DialogueBox.SetActive (true);
		CharacterText.text = "We're doing fine without any sky peep help, ok?";
		CharacterSprite.GetComponent<Image> ().sprite = BrianSprite;
		GetComponent<AudioSource> ().PlayOneShot (BrianVoice);
	}

	public void Howard(){
		DialogueBox.SetActive (true);
		CharacterText.text = "You came to help? We’re pretty good ourselves. No help needed. Thanks for offering though!";
		CharacterSprite.GetComponent<Image> ().sprite = BrianSprite;
		GetComponent<AudioSource> ().PlayOneShot (BrianVoice);
	}

	public void EndDialogue(){
		DialogueBox.SetActive (false);
		GetComponent<AudioSource> ().Stop ();
	}
}
