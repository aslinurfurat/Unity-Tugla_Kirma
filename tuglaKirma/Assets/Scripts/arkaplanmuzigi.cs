using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanmuzigi : MonoBehaviour {
	static bool SahnedeMuzikVar;
	// Use this for initialization
	void Start () {
		if (!SahnedeMuzikVar) {
			GameObject.DontDestroyOnLoad (this.gameObject);
			SahnedeMuzikVar = true;
		} else {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
