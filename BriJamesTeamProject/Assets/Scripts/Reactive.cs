using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]

public class Reactive : MonoBehaviour {


	public Rigidbody _myRigidbody;
	public bool aSplode;

	private float timer;
	private float timerTarget = 0.5f;
	public bool explodable;
	public int charge;
	private float baseXZ = 200f;
	private float baseY = 200f;
	private float baseMaxY = 400f;
	private float incrementXZ = 100f;
	private float incrementY = 100f;

	// Use this for initialization
	void Start () {
		baseXZ = baseXZ;
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
			float XZ = 1;
			float Y = 1;
			switch (charge){
			case 1:
				XZ = incrementXZ * 1;
				Y = incrementY * 1;
				//incrementY = 
				break;
				
			case 2:
				XZ = incrementXZ * 2;
				Y = incrementY * 2;
				break;
				
			case 3:
				XZ = incrementXZ * 3;
				Y = incrementY * 3;
				break;
				
			case 4:
				XZ = incrementXZ * 4;
				Y = incrementY * 4;
				break;
			}
			Vector3 deadFly = new Vector3(Random.Range(-baseXZ - XZ, baseXZ + XZ),Random.Range(baseY + Y, baseMaxY + Y),Random.Range(-baseXZ - XZ, baseXZ + XZ));
			_myRigidbody.AddForce(deadFly);
			aSplode = false;
		}


	
	}
}
