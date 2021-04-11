using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour {
	public AudioClip sesEfektiTuglaKirilma;
	public AudioClip sesEfektiTuglaCarpma;
	public static int toplamTuglaSayisi;
	public Sprite[] tuglaSprite;
	private int maxcarpmasayisi;
	private int carpmasayisi;
	private Puan puanScripti;
	// Use this for initialization
	void Start () {
		maxcarpmasayisi=tuglaSprite.Length+1;
		toplamTuglaSayisi++;
		puanScripti = GameObject.FindObjectOfType<Puan> ().GetComponent<Puan> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D diger){
		if (diger.gameObject.name.Equals("top")){
			puanScripti.puanArttir ();
			carpmasayisi++;
			if (carpmasayisi >= maxcarpmasayisi) {
				toplamTuglaSayisi--;
				Debug.Log (toplamTuglaSayisi);
				if (toplamTuglaSayisi <= 0) {
					GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
				}
				AudioSource.PlayClipAtPoint (sesEfektiTuglaKirilma, transform.position);
				Destroy (gameObject);
			} else {
				AudioSource.PlayClipAtPoint (sesEfektiTuglaCarpma, transform.position);
				GetComponent<SpriteRenderer> ().sprite = tuglaSprite [carpmasayisi - 1];
			}
		}
	}
}
