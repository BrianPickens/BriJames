using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

	public float rotationSpeed = 250f;

	private Transform _myTransform;


	void Awake(){
		_myTransform = transform;
	}

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) {
			_myTransform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
		}

	}
}
