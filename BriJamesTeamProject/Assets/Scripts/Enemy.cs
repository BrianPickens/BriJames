using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform Target;
	public float speed = 5f;
	public Transform _myTransform;
	public Rigidbody _myRigidbody;
	public bool dead;
	public bool deadAnim = true;
	public float minXZ = -400f;
	public float maxXZ = 400f;
	public float minY = 200f;
	public float maxY = 400f;
    private float timer;
    public float timerTarget;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponentInChildren<Animator> ();
        timer = timerTarget;
		gameObject.tag = "Rabbit";
		deadAnim = true;
		_myRigidbody = GetComponent<Rigidbody> ();
		_myTransform = transform;
		Target = null;

	}
	
	// Update is called once per frame
	void Update () {
	

		Debug.Log (_myRigidbody.velocity.z);

		anim.SetFloat ("WalkDirection", _myRigidbody.velocity.z);


		if (Target != null && !dead) {
		//	Target.position = new Vector3 (Target.position.x, _myTransform.position.y, Target.position.z);
		//	_myTransform.LookAt(Target);
			_myTransform.position = Vector3.MoveTowards(_myTransform.position, Target.position, Time.deltaTime * speed);
		}

		if (!deadAnim) {
			Vector3 deadFly = new Vector3(Random.Range(minXZ,maxXZ),Random.Range(minY, maxY),Random.Range(minXZ,maxXZ));
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
            }
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
