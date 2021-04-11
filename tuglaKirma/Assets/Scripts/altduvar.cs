using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class altduvar : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D diger){
		if (diger.gameObject.name.Equals ("top")) {
			SceneManager.LoadScene("OyunuKaybettiniz");
		}
	}
}
