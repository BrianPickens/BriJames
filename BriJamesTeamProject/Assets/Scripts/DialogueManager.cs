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
	

	// Use this for initialization
	void Start () {
		DialogueBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Npc1(){
		DialogueBox.SetActive (true);
		CharacterText.text = "I Dare YOU to Jump!";
		CharacterSprite.GetComponent<Image> ().sprite = NPC1Sprite;
	}

	public void James(){
		DialogueBox.SetActive (true);
		CharacterText.text = "I love my home!";
		CharacterSprite.GetComponent<Image> ().sprite = JamesSprite;
	}

	public void JamesAngry(){
		DialogueBox.SetActive (true);
		CharacterText.text = "I remember when I had a home...It was great to feel safe.";
		CharacterSprite.GetComponent<Image> ().sprite = JamesSprite;
	}

	public void Brian(){
		DialogueBox.SetActive (true);
		CharacterText.text = "What brings you here?";
		CharacterSprite.GetComponent<Image> ().sprite = BrianSprite;
	}

	public void EndDialogue(){
		DialogueBox.SetActive (false);
	}
}
