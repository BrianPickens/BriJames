using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip Beam;
	public AudioClip Hit;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().volume = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MakeSound(){

		this.GetComponent<AudioSource> ().PlayOneShot (Beam);
	}

	public void HitOther(){

		this.GetComponent<AudioSource> ().PlayOneShot (Hit);
	}
}
