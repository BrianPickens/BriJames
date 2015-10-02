using UnityEngine;
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
	public GameObject DamageArea;

	public GameObject SoundMaker;


	void Awake(){
		SoundMaker = GameObject.FindWithTag ("SoundManager");
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

		if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Return))
		{
			DamageArea.SetActive (false);
			AttackArea.SetActive (true);
			SoundMaker.GetComponent<SoundManager>().MakeSound();
		}
		
		else
		{
			AttackArea.SetActive (false);
			DamageArea.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			_myRigidbody.AddForce(Vector3.up * jumpForce);
		}
	}
}
