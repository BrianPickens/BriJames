using UnityEngine;
using System.Collections;

public class Cow : MonoBehaviour {

	public Transform _myTransform;
	public Rigidbody _myRigidbody;
	//public bool dead;
	public bool deadAnim = true;
	public float minXZ = -400f;
	public float maxXZ = 400f;
	public float minY = 200f;
	public float maxY = 400f;


	// Use this for initialization
	void Start () {
		gameObject.tag = "Cow";
		deadAnim = true;
		_myRigidbody = GetComponent<Rigidbody> ();
		_myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (!deadAnim) {
			Vector3 deadFly = new Vector3(Random.Range(minXZ,maxXZ),Random.Range(minY, maxY),Random.Range(minXZ,maxXZ));
			_myRigidbody.AddForce(deadFly);
			deadAnim = true;
		}
	}
}
