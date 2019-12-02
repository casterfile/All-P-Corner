using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour {
	public static bool isTesting = false;
	// Use this for initialization
	void Awake () {
		#if UNITY_EDITOR
		isTesting = false;
		#endif	

		//print ("isTesting: "+ isTesting);
	}
}
