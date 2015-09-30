using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject SoundMaker;
	public float growRate = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset(){

	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Rabbit")
        {
			SoundMaker.GetComponent<SoundManager>().HitOther();
			other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Enemy>().dead = true;
			other.gameObject.GetComponent<Enemy>().deadAnim = false;
           // Destroy(other.gameObject);
        }

		if (other.gameObject.tag == "Explodable") {
			SoundMaker.GetComponent<SoundManager>().HitOther();
			other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Reactive>().aSplode = true;

		}
		if(other.gameObject.tag == "Cow")
		{
			SoundMaker.GetComponent<SoundManager>().HitOther();
			//other.gameObject.GetComponent<Rigidbody>().mass = 1;
			other.gameObject.GetComponent<Cow>().deadAnim = false;
			// Destroy(other.gameObject);
		}

    }
}
