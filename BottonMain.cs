/* Script BottonMain, se utiliza principalmente para el OnClick,
 * de los botones del UI de Unity.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.3.2 @2015/16
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BottonMain : MonoBehaviour {
	public GameObject MenuSecond;
	scorev2 sv2;

	void Awake(){
		sv2 = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
	}

	public void Jugar(bool actv){
		if(actv == true){SceneManager.LoadScene(1); sv2.score = 0; sv2.restor = 8;}
	}
	public void Salir(bool act){
		if(act == true){Application.Quit();
			Debug.Log("Quit enabled");}
	}
	public void Princi(bool acti){
		if(acti == true){SceneManager.LoadScene(0); sv2.score = 0; sv2.restor = 8;}}

	public void ActUI(bool atv){
		if(atv == false){MenuSecond.SetActive(false);}
		else{MenuSecond.SetActive(true);}
	}
}
