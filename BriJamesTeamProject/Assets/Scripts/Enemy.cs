using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform Target;
	public float speed = 5f;


	// Use this for initialization
	void Start () {
	
		Target = null;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Target != null) {
			transform.position = Vector3.MoveTowards(transform.position, Target.position, Time.deltaTime * speed);
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
