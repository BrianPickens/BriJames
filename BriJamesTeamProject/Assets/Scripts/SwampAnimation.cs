using UnityEngine;
using System.Collections;

public class SwampAnimation : MonoBehaviour {

	public Material Swamp1;
	public Material Swamp2;
	public Material Swamp3;

	private float timer;
	private int animationPhase;

	MeshRenderer _MyRenderer;


	// Use this for initialization
	void Start () {
		timer = 0.75f;
		animationPhase = 0;
		_MyRenderer = GetComponent<MeshRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		timer -= Time.deltaTime;
		if(timer < 0){
			animationPhase += 1;
			if(animationPhase == 3){
				animationPhase = 0;
			}
			timer = 0.75f;
		}


		if (animationPhase == 0) {
			_MyRenderer.material = Swamp1;
		}

		if (animationPhase == 1) {
			_MyRenderer.material = Swamp2;
		}

		if (animationPhase == 2) {
			_MyRenderer.material = Swamp3;
		}

	}
}
