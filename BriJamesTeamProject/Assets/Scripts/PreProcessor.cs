using UnityEngine;
using System.Collections;

public class PreProcessor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR_WIN
		MainCharacterAnimator.windows = true;
		#endif
		
		#if UNITY_STANDALONE_WIN
		MainCharacterAnimator.windows = true;
		#endif
		
		#if UNITY_STANDALONE_OSX
		MainCharacterAnimator.osx = true;
		#endif
	}

}
