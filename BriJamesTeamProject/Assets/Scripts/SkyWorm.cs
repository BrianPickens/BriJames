using UnityEngine;
using System.Collections;

public class SkyWorm : MonoBehaviour {

	public Vector3 _startTransform;
	public Vector3 _myTarget;
	private bool hide;

	// Use this for initialization
	void Start () {
		hide = false;
		_startTransform = transform.position;
		_myTarget = new Vector3 (transform.position.x, transform.position.y - 5f, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (hide) {
			transform.position = Vector3.Lerp(transform.position, _myTarget, 1f * Time.deltaTime);
		} 

		if (!hide) {
			transform.position = Vector3.Lerp(transform.position, _startTransform, 1f * Time.deltaTime);
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			hide = true;

		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			hide = false;

		}
	}
}
