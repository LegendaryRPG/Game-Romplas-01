/* 
 * Script finlevel, basicamente carga un nuevo level, evitando que se elimine un
 * gameobject especifico para ser utilizado en el siguiente level.
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
