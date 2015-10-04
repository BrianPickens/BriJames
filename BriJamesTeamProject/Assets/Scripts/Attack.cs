using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject SoundMaker;
	public float growRate = 0.5f;
	public float explodeRate = 10f;
	public Transform _myTransform;
	public int charging;

	// Use this for initialization

	void Start () {
		charging = 0;
		_myTransform = transform;
		SoundMaker = GameObject.FindWithTag ("SoundManager");
		transform.localScale = new Vector3 (10f,20f,10f);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (charging);
		if (charging == 0) {
			MeshRenderer renderer = GetComponent<MeshRenderer> ();
			Material material = renderer.material;
			Color color = renderer.material.color;
			color.a = 0.0f;
			renderer.material.color = color;
			gameObject.SetActive (false);
		} else if (transform.localScale.x > 1 && charging == 1) {
			MeshRenderer renderer = GetComponent<MeshRenderer> ();
			Material material = renderer.material;
			Color color = renderer.material.color;
			if (color.a < 0.5f) {
				color.a += 0.01f;
			}
			renderer.material.color = color;
			transform.localScale -= new Vector3 (growRate, 0f, growRate);
		} else if (transform.localScale.x < 10 && charging == 2) {
			MeshRenderer renderer = GetComponent<MeshRenderer> ();
			Material material = renderer.material;
			Color color = renderer.material.color;
			color.a = 0.5f;
			renderer.material.color = color;
			transform.localScale += new Vector3 (explodeRate, 0f, explodeRate);

		}
		else {

			charging = 0;

		}

	}

	public void ResetSize(){
		transform.localScale = new Vector3 (10f, 20f, 10f);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Rabbit" && charging == 2)
        {
			SoundMaker.GetComponent<SoundManager>().HitOther();
			other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Enemy>().dead = true;
			other.gameObject.GetComponent<Enemy>().deadAnim = false;
           // Destroy(other.gameObject);
        }

		if (other.gameObject.tag == "Explodable" && charging == 2) {
			SoundMaker.GetComponent<SoundManager>().HitOther();
			other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Reactive>().aSplode = true;

		}
		if(other.gameObject.tag == "Cow" && charging == 2)
		{
			SoundMaker.GetComponent<SoundManager>().HitOther();
			//other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Cow>().deadAnim = false;
			// Destroy(other.gameObject);
		}

    }
}
