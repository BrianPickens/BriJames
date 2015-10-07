using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]

public class Reactive : MonoBehaviour {


	public Rigidbody _myRigidbody;
	public bool aSplode;

	private float timer;
	private float timerTarget = 1f;
	public bool explodable;

	// Use this for initialization
	void Start () {
		explodable = true;
		timer = timerTarget;
		aSplode = false;
		_myRigidbody = GetComponent<Rigidbody> ();
	//	_myRigidbody.freezeRotation = true;
	
		gameObject.tag = "Explodable";
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!explodable) {
			timer -= Time.deltaTime;
			if(timer < 0){
				explodable = true;
				timer = timerTarget;
			}
		}

		if (aSplode) {
			Vector3 deadFly = new Vector3(Random.Range(-400,400),Random.Range(200,400),Random.Range(-400,400));
			_myRigidbody.AddForce(deadFly);
			aSplode = false;
		}


	
	}
}
