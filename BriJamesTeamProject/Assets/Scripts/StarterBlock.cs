using UnityEngine;
using System.Collections;

public class StarterBlock : MonoBehaviour {

	public GameObject BeamOfLight;
	public GameObject Cloud1;
	public GameObject Cloud2;
	public bool clouds;
	public bool shrink;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (shrink && BeamOfLight != null) {
			BeamOfLight.transform.localScale -= new Vector3 (0.01f, 0.01f, 0.01f);
			if(BeamOfLight.transform.localScale.x < 0){
				Destroy (BeamOfLight);
			}
		}

		if (clouds) {
			if(Cloud1 != null){
				Cloud1.SetActive (true);
				if(Cloud1.transform.position.x < -355){
				Cloud1.transform.position += new Vector3 (20,0,0);
				}
			}

			if(Cloud2 != null){
				Cloud2.SetActive (true);
				if(Cloud2.transform.position.x > 355){
				Cloud2.transform.position += new Vector3(-20,0,0);
				}
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			shrink = true;
			clouds = true;
		}
	}
}
