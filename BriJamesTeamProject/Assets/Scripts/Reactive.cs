using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
[RequireComponent (typeof (AudioSource))]

public class Reactive : MonoBehaviour {

	public AudioClip hit;
	AudioSource audio;
	public Rigidbody _myRigidbody;
	public bool aSplode;

	private float crashTimer;
	private bool ableToCrash;

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
		audio = GetComponent<AudioSource> ();
		crashTimer = 1f;
		baseXZ = baseXZ;
		explodable = true;
		timer = timerTarget;
		aSplode = false;
		_myRigidbody = GetComponent<Rigidbody> ();
	//	_myRigidbody.freezeRotation = true;
		//audio.rolloffMode(linear);
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

		if (!ableToCrash) {
			crashTimer -= Time.deltaTime;
			if(crashTimer < 0){
				ableToCrash = true;
				crashTimer = 1f;
			}
		}

	
	}

	void OnCollisionEnter (Collision collision){
		
		if (collision.gameObject.tag == "Explodable" && ableToCrash) {
			if(collision.relativeVelocity.magnitude > 5){
			audio.pitch = Random.Range(0.8f, 1.2f);
			audio.PlayOneShot(hit);
				ableToCrash = false;
			}
		}
		
		if (collision.gameObject.tag == "Ground") {
			if(collision.relativeVelocity.magnitude > 5){
			audio.pitch = Random.Range(0.8f, 1.2f);
			audio.PlayOneShot(hit);
			}
		}
	}
}
