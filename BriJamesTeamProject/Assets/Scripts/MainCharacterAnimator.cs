﻿using UnityEngine;
using System.Collections;

public class MainCharacterAnimator : MonoBehaviour {

	public static bool osx = false;
	public static bool windows = false;

	Animator anim;
	GameObject Player;
	private bool controllerSupport;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		Player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if (Mathf.Abs (Input.GetAxis ("LeftJoystickX")) > 0 || Mathf.Abs (Input.GetAxis ("LeftJoystickY")) > 0) {
			controllerSupport = true;
		}

	if (!controllerSupport) {
			if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
				anim.SetBool ("Left", true);
			}


			if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.LeftArrow)) {
				anim.SetBool ("Left", false);
			}

			if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) {
				anim.SetBool ("Right", true);
			}
			if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.RightArrow)) {
				anim.SetBool ("Right", false);
			}

			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) {
				anim.SetBool ("Back", true);
			}
			if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow)) {
				anim.SetBool ("Back", false);
			}

			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
				anim.SetBool ("Front", true);
			}
			if (Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.DownArrow)) {
				anim.SetBool ("Front", false);
			}
		}
		if (controllerSupport) {
			if(windows){
				if (Input.GetAxis ("LeftJoystickX") > 0f) {
					anim.SetBool ("Left", false);
					anim.SetBool ("Front", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Right", true);
					//	Debug.Log ("right");
				} else if (Input.GetAxis ("LeftJoystickX") < 0f) {
					anim.SetBool ("Right", false);
					anim.SetBool ("Front", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Left", true);
					//	Debug.Log ("left");
				} else if (Input.GetAxis ("LeftJoystickY") > 0.2f) {
					anim.SetBool ("Right", false);
					anim.SetBool ("Left", false);
					anim.SetBool ("Front", false);
					anim.SetBool ("Back", true);
					//	Debug.Log ("back");
				} else if (Input.GetAxis ("LeftJoystickY") < 0.2f) {
					anim.SetBool ("Right", false);
					anim.SetBool ("Left", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Front", true);
					//	Debug.Log ("front");
				} else {
					anim.SetBool ("Right", false);
					anim.SetBool ("Left", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Front", true);
					//Debug.Log ("normalize");
				}
			}

			if(osx){
				if (Input.GetAxis ("MacLeftJoystickX") > 0f) {
					anim.SetBool ("Left", false);
					anim.SetBool ("Front", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Right", true);
					//	Debug.Log ("right");
				} else if (Input.GetAxis ("MacLeftJoystickX") < 0f) {
					anim.SetBool ("Right", false);
					anim.SetBool ("Front", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Left", true);
					//	Debug.Log ("left");
				} else if (Input.GetAxis ("MacLeftJoystickY") > 0.2f) {
					anim.SetBool ("Right", false);
					anim.SetBool ("Left", false);
					anim.SetBool ("Front", false);
					anim.SetBool ("Back", true);
					//	Debug.Log ("back");
				} else if (Input.GetAxis ("MacLeftJoystickY") < 0.2f) {
					anim.SetBool ("Right", false);
					anim.SetBool ("Left", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Front", true);
					//	Debug.Log ("front");
				} else {
					anim.SetBool ("Right", false);
					anim.SetBool ("Left", false);
					anim.SetBool ("Back", false);
					anim.SetBool ("Front", true);
					//Debug.Log ("normalize");
				}
			}
		}

		if (Player.GetComponent<RigidBodyMovement> ().grounded) {
			anim.SetBool ("jump", false);
		}

		if (!Player.GetComponent<RigidBodyMovement> ().grounded) {
			anim.SetBool ("jump", true);
		}


	}
}
