using UnityEngine;
using System.Collections;

public class SkyWorm : MonoBehaviour {

	public Transform _myTransform;
	public Vector3 _myTarget;
	private bool hide;

	// Use this for initialization
	void Start () {
		_myTransform = transform;
		_myTarget = new Vector3 (_myTransform.position.x, _myTransform.position.y - 5f, _myTransform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (hide) {
			transform.position = Vector3.Lerp(transform.position, _myTarget, 1 * Time.deltaTime);
		} else {
			transform.position = Vector3.Lerp(_myTarget, _myTransform.position, 1 * Time.deltaTime);
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			hide = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "PLayer") {
			hide = false;
		}
	}
}
