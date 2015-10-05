using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip Beam;
	public AudioClip Hit;
	public AudioClip Jump;
	public AudioClip Land;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MakeSound(){
		GetComponent<AudioSource> ().volume = 0.25f;
		this.GetComponent<AudioSource> ().PlayOneShot (Beam);
	}

	public void HitOther(){
		GetComponent<AudioSource> ().volume = 1f;
		this.GetComponent<AudioSource> ().PlayOneShot (Hit);
	}

	public void CharJump(){
		GetComponent<AudioSource> ().volume = 1f;
		this.GetComponent<AudioSource> ().PlayOneShot (Jump);
	}

	public void CharLand(){
		GetComponent<AudioSource> ().volume = 1f;
		this.GetComponent<AudioSource> ().PlayOneShot (Land);
	}
}
