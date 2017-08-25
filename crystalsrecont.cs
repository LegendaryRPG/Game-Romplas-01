/* Script crystalsrecont, modifica la variable score del script scorev2, cada vez
 * que el player activa el trigger del Gameobject de esta script, y luego lo elimina.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.3.2 @2015/16
 */

using UnityEngine;
using System.Collections;

public class crystalsrecont : MonoBehaviour {
	scorev2 nscore;
	GameObject Player;
	void Awake(){
		nscore = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
		Player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update(){}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject == Player){ nscore.score++; Destroy(this.gameObject);}
	}
}
