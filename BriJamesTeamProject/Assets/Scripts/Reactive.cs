using UnityEngine;
using System.Collections;

public class Reactive : MonoBehaviour {


	public Rigidbody _myRigidbody;
	public bool aSplode;

	// Use this for initialization
	void Start () {
		aSplode = false;
		_myRigidbody = GetComponent<Rigidbody> ();
		gameObject.tag = "Explodable";
	
	}
	
	// Update is called once per frame
	void Update () {

		if (aSplode) {
			Vector3 deadFly = new Vector3(Random.Range(-400,400),Random.Range(200,400),Random.Range(-400,400));
			_myRigidbody.AddForce(deadFly);
			aSplode = false;
		}
	
	}
}
