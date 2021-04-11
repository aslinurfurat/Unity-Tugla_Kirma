using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvarses : MonoBehaviour {
	public AudioClip sesEfekti;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D diger){
		AudioSource.PlayClipAtPoint (sesEfekti, transform.position);
	}

}
