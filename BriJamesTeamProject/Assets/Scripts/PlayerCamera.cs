using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public Transform target;
	//public Transform objectTarget;
	public float walkDistance;
	public float height;
	public float xSpeed = 250f;
	public float ySpeed = 120f;
	public float heightDamping = 2f;
	public float rotationDamping = 3f;

	private float _x;
	private float _y;
	
	private bool _cameraButton = false;
	private Transform _myTransform;
	// Use this for initialization

	void Awake(){
		_myTransform = transform;
		target = GameObject.FindWithTag ("Player").GetComponent<Transform>();
	}

	void Start () {
	
		if (target == null) {
			Debug.Log ("everything is broken! Panic!");
		}


		CameraStart ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown (1)) {
			_cameraButton = true;
		}
		if (Input.GetMouseButtonUp (1)) {
			_cameraButton = false;
		}


	}

	void LateUpdate(){

		if (_cameraButton) {
			_x += Input.GetAxis ("Mouse X") * xSpeed * 0.02f;
			_y += Input.GetAxis ("Mouse Y") * ySpeed * 0.02f;

			Quaternion rotation = Quaternion.Euler (_y, _x, 0);
			//Vector3 position = rotation * new Vector3 (0.0f, 0.0f, -walkDistance) + target.position;
			Vector3 position = rotation * new Vector3 (0, 0, -walkDistance) + target.position;

			_myTransform.rotation = rotation;
			_myTransform.position = position;
		} else {
	//		_myTransform.position = new Vector3 (target.position.x, target.position.y + height, target.position.z - walkDistance);
		//	_myTransform.LookAt (target);
			_x = 0;
			_y = 0;

			float wantedRotationAngle = target.eulerAngles.y;
			float wantedHeight = target.position.y + height;

			float currentRotationAngle = _myTransform.eulerAngles.y;
			float currentHeight = _myTransform.position.y;

			currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

			currentHeight = Mathf.Lerp (currentHeight,wantedHeight, heightDamping * Time.deltaTime);

			Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

			_myTransform.position = target.position;
			_myTransform.position -= currentRotation * Vector3.forward * walkDistance;

			_myTransform.position = new Vector3(_myTransform.position.x,  currentHeight, _myTransform.position.z);

			_myTransform.LookAt (target);

		}


	}

	public void CameraStart(){
			_myTransform.position = new Vector3 (target.position.x, target.position.y + height, target.position.z - walkDistance);
			_myTransform.LookAt (target);
	}
}
