﻿using UnityEngine;
using System.Collections;

public class RigidBodyMovement : MonoBehaviour {

	Rigidbody _myRigidbody;
	public float speed = 0f;
	public float jumpForce = 100f;
	[Range(1f, 4f)][SerializeField] float gravityMultiplier = 2f;
	public bool grounded;

	public Transform GroundCheck;
	public float groundRadius = 0.2f;
	public LayerMask WhatisGround;

	public GameObject AttackArea;
	//public GameObject DamageArea;

	public GameObject SoundMaker;
	public GameObject GrassSound;
	private Light ChargeLight;
	public GameObject SunLight;
	public Color color1;
	public Color color2;
	public Camera camera;
	private float duration = 2f;
	private float t;


	void Awake(){
		SoundMaker = GameObject.FindWithTag ("SoundManager");
		ChargeLight = this.GetComponent<Light>();
		SunLight = GameObject.FindWithTag ("Sun");
		camera = Camera.main;
		color1 = camera.backgroundColor;
		color2 = Color.black;
		_myRigidbody = this.GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate(){

		Collider[] hitColliders = Physics.OverlapSphere (GroundCheck.position, groundRadius, WhatisGround);
		int i = 0;
		
		if (i < hitColliders.Length) {
			if(!grounded){
			SoundMaker.GetComponent<SoundManager>().CharLand();
			}
			grounded = true;
		} else {
			grounded = false;
			Vector3 extraGravityForce = (Physics.gravity * gravityMultiplier) - Physics.gravity;
			_myRigidbody.AddForce(extraGravityForce);
		}




		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x * speed, _myRigidbody.velocity.y, y * speed);
		_myRigidbody.velocity = movement;

	}


	void Update () {

		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Return)) {
			SoundMaker.GetComponent<SoundManager> ().MakeSound ();
		}

		if (Input.GetMouseButton (0) || Input.GetKey (KeyCode.Return)) {
			AttackArea.SetActive (true);
			AttackArea.GetComponent<Attack> ().charging = 1;
			ChargeLight.intensity += 0.10f;
			SunLight.GetComponent<Light> ().intensity -= 0.01f;



			Color lerpcolor = Color.Lerp(color1, color2, t);
			if( t < 1){
				t += Time.deltaTime/duration;
			}

			camera.backgroundColor = lerpcolor;
		} else if (Input.GetMouseButtonUp (0) || Input.GetKeyUp (KeyCode.Return)) {
			AttackArea.GetComponent<Attack> ().charging = 2;
			SoundMaker.GetComponent<SoundManager> ().Release ();
			ChargeLight.intensity = 0f;
			camera.backgroundColor = color1;
			t = 0f;
			SunLight.GetComponent<Light>().intensity = 8;

		} else {
			if (SunLight.GetComponent<Light> ().intensity > 1.25f) {
				SunLight.GetComponent<Light> ().intensity -= 0.25f;
			}

		//	camera.backgroundColor = Color.Lerp(camera.backgroundColor, color1, Time.time * 0.25f);

		}

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			SoundMaker.GetComponent<SoundManager>().CharJump();
			_myRigidbody.AddForce(Vector3.up * jumpForce);
		}
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Grass") {
			if(Mathf.Abs(Input.GetAxis ("Horizontal")) > 0 || Mathf.Abs(Input.GetAxis ("Vertical")) > 0){
				GrassSound.GetComponent<AudioSource>().volume = 0.25f;
			}
			else {
				GrassSound.GetComponent<AudioSource>().volume = 0f;
			}
		}

	}

	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Grass") {
			GrassSound.GetComponent<AudioSource>().volume = 0f;
		}
	}
}
