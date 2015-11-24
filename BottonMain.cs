/* Script BottonMain, se utiliza principalmente para el OnClick,
 * de los botones del UI de Unity.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.2 @2015
 */

using UnityEngine;
using System.Collections;

public class BottonMain : MonoBehaviour {
	public void Inicio(){
		Application.LoadLevel(1);
	}
	public void Salir(bool act){
		if(act == true){Application.Quit();
			Debug.Log("Quit enabled");}
	}
	public void Main(){
		Application.LoadLevel(0);}
}
