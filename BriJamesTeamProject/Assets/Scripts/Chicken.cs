using UnityEngine;
using System.Collections;

public class Chicken : MonoBehaviour {

	private Transform _myTransform;
	private Rigidbody _myRigidbody;
	private Vector3 _targetVector;
	private float speed = 10f;
	private float timer = 0.2f;
	private bool arrived;
	private float travelTimer = 2f;

	// Use this for initialization
	void Start () {
		_myRigidbody = GetComponent<Rigidbody> ();
		_myTransform = transform;
		_targetVector = new Vector3(_myTransform.position.x + Random.Range (-5f,5f),_myTransform.position.y, _myTransform.position.z + Random.Range (-5f,5f));

	}
	
	// Update is called once per frame
	void Update () {
		if (_myTransform.position == _targetVector) {
				timer -= Time.deltaTime;
				if(timer < 0){
				Debug.Log ("normal");
				_targetVector = new Vector3(_myTransform.position.x + Random.Range (-5f,5f),_myTransform.position.y, _myTransform.position.z + Random.Range (-5f,5f));
				travelTimer = 2f;
				timer = 0.2f;
				}
		} 

		else{
			travelTimer -= Time.deltaTime;
			_myTransform.position = Vector3.MoveTowards (_myTransform.position, _targetVector, Time.deltaTime * speed);
			if(travelTimer < 0){
				Debug.Log ("save");
				_targetVector = new Vector3(_myTransform.position.x + Random.Range (-5f,5f),_myTransform.position.y, _myTransform.position.z + Random.Range (-5f,5f));
				travelTimer = 2f;
				timer = 0.2f;
			}
		}


	}
}
