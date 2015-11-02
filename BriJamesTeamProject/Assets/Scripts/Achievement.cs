using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achievement : MonoBehaviour {

	public static Achievement achievement;
	public static int cowPush;
	public static int chickenHit;
	public static int rabbitHit;

	public GameObject GodHead;
	public GameObject GodText;

	private float godTimer;

	void Awake(){
		if (achievement == null) {
			DontDestroyOnLoad (gameObject);
			achievement = this;
		} else if (achievement != this){
			Destroy(gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		godTimer = 5f;
		GodHead.SetActive (false);
		GodText.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	


	}
}
