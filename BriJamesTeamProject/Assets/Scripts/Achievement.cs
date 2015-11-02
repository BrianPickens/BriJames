using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achievement : MonoBehaviour {

	public static Achievement achievement;
	public static int cowPush;
	public static int chickenHit;
	public static int rabbitHit;

	public GameObject GodHead;
	public GameObject GodWords;
	public Text GodText;

	public int chickcheck;
	private float godTimer;
	private bool showText;
	private bool cowAch;
	private bool chickenAch;
	private bool rabbitAch;

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
		GodWords.SetActive (false);
		GodText.text = " ";
	}
	
	// Update is called once per frame
	void Update () {
	
		chickcheck = chickenHit;

		if (cowPush > 2 && !cowAch) {
			showText = true;
			cowAch = true;
			GodText.text = "Cow Tipper Achievement!";
		}

		if (chickenHit > 2 && !chickenAch) {
			showText = true;
			chickenAch = true;
			GodText.text = "Chicken Saver Achievement!";
		}

		if (rabbitHit > 2 && !rabbitAch) {
			showText = true;
			rabbitAch = true;
			GodText.text = "Rabbit Smacker Achievement!";
		}

		if (showText) {
			GodHead.SetActive (true);
			GodWords.SetActive (true);
			godTimer -= Time.deltaTime;
			if(godTimer < 0){
				GodHead.SetActive (false);
				GodWords.SetActive (false);
				godTimer = 5f;
				showText = false;
			}

		}


	}
}
