using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

	public float moveSpeed = 5f;
	public float rotationSpeed = 250f;

	private Transform _myTransform;
	private CharacterController _controller;


	void Awake(){
		_myTransform = transform;
		_controller = GetComponent<CharacterController> ();
	}

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) {
			_myTransform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
		}

		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0) {
			_controller.SimpleMove(_myTransform.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * moveSpeed);
		}

	}
}
