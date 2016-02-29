/* Script finlevel, basicamente carga un nuevo level, evitando que se elimine un
 * gameobject especifico para ser utilizado en el siguiente level.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.3.2 @2015/16
 */ 

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class finlevel : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Object.DontDestroyOnLoad(GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>());
			SceneManager.LoadScene(2);}
	}
}
