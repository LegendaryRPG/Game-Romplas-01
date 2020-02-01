/* 
 * Script crystalsrecont, modifica la variable score del script scorev2, cada vez
 * que el player activa el trigger del Gameobject de esta script, y luego lo elimina.
 */

using UnityEngine;
using System.Collections;

public class crystalsrecont : MonoBehaviour {
	scorev2 nscore;
	GameObject Player;
	AudioSource playr;
	public AudioClip AudCilp;

	void Awake(){
		nscore = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
		Player = GameObject.FindGameObjectWithTag("Player");
		playr = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
	}

	void Start(){
		playr.clip = AudCilp;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject == Player){
			nscore.score++; 
			playr.Play();
			Destroy(this.gameObject);
        }
	}
}
