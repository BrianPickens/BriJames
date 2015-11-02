using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
	
	public GameObject DialogueBox;
	public GameObject CharacterSprite;
	public Text CharacterText;
	public Sprite NPC1Sprite;
	

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

	public void EndDialogue(){
		DialogueBox.SetActive (false);
	}
}
