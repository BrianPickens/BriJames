﻿using UnityEngine;
using System.Collections;

public class MoveSide : MonoBehaviour {

	public float gravity = 20f;
	public float moveSpeed = 5f;
	public float rotationSpeed = 250f;
	public float strafeSpeed = 4f;
	public float jumpHeight = 8f;
	public CollisionFlags _collisionFlags;
	
	private Vector3 _moveDirection;
	private Transform _myTransform;
	private CharacterController _controller;
	
	void Awake(){
		_myTransform = transform;
		_controller = GetComponent<CharacterController> ();
	}
	// Use this for initialization
	void Start () {
		_moveDirection = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
//		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) {
//			_myTransform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
//		}
		
		if (_controller.isGrounded) {
			
			_moveDirection = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
			_moveDirection = _myTransform.TransformDirection(_moveDirection).normalized;
			_moveDirection *= moveSpeed;
			
			if(Input.GetKeyDown(KeyCode.Space)){
				_moveDirection.y += jumpHeight;
			}
		}	
		
		else {
			if((_collisionFlags & CollisionFlags.CollidedBelow) == 0){
				
			}
		}
		_moveDirection.y -= gravity * Time.deltaTime;
		_collisionFlags = _controller.Move(_moveDirection * Time.deltaTime);
		
	}
}