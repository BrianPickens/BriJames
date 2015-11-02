using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class SwampWorm : MonoBehaviour {
	


	public Transform _myTransform;
	public Rigidbody _myRigidbody;
	public bool dead;
	public bool deadAnim = true;
	public float baseXZ = 400f;
	public float baseY = 200f;
	public float baseMaxY = 400f;
	public float incrementXZ = 200f;
	public float incrementY = 200f;
	private float timer;
	public float timerTarget;
	public bool explodable;
	public int charge;
	public AudioClip scaryLaugh;
	
	Animator anim;
	
	// Use this for initialization
	void Start () {
		explodable = true;
		anim = GetComponent<Animator> ();
		timer = timerTarget;
		gameObject.tag = "SwampWorm";
		deadAnim = true;
		_myRigidbody = GetComponent<Rigidbody> ();
		_myTransform = transform;
		
	}
	
	// Update is called once per frame
	void Update () {
				
		if (!dead) {
	//		anim.SetBool ("Scream", false);
		}
		
		if (!deadAnim) {
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
			deadAnim = true;
		}
		
		if (dead && deadAnim)
		{
			timer -= Time.deltaTime;
			if (timer <= 0)
			{
				dead = false;
				timer = timerTarget;
				explodable = true;
				_myRigidbody.mass = 100f;
			}
		}
		
	}
	
	public void SetScreamOn(){
		anim.SetBool ("Scream", true);
	}

	public void SetScreamOff(){
		anim.SetBool ("Scream", false);
	}

}