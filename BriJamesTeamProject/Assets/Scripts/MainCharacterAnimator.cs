using UnityEngine;
using System.Collections;

public class MainCharacterAnimator : MonoBehaviour {

	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetBool ("Left", true);
		}

		if (Input.GetKeyUp (KeyCode.A)) {
			anim.SetBool ("Left", false);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool ("Right", true);
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			anim.SetBool ("Right", false);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			anim.SetBool ("Back", true);
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			anim.SetBool ("Back", false);
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			anim.SetBool ("Front", true);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			anim.SetBool ("Front", false);
		}


	}
}
