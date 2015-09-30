using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform Target;
	public float speed = 5f;
	public Transform _myTransform;
	public Rigidbody _myRigidbody;
	public bool dead;
	public bool deadAnim = true;



	// Use this for initialization
	void Start () {
		deadAnim = true;
		_myRigidbody = GetComponent<Rigidbody> ();
		_myTransform = transform;
		Target = null;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Target != null && !dead) {
			//Target.position = new Vector3 (Target.position.x, _myTransform.position.y, Target.position.z);
			_myTransform.LookAt(Target);
			_myTransform.position = Vector3.MoveTowards(_myTransform.position, Target.position, Time.deltaTime * speed);
		}

		if (!deadAnim) {
			Vector3 deadFly = new Vector3(Random.Range(-400,400),Random.Range(200,400),Random.Range(-400,400));
			_myRigidbody.AddForce(deadFly);
			deadAnim = true;
		}
	
	}

	public void SetTarget(){
		Target = GameObject.FindWithTag ("Player").transform;
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Damage") {
			Debug.Log ("Damage");
		}

	}
}
