/* Script BottonMain, se utiliza principalmente para el OnClick,
 * de los botones del UI de Unity.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.2 @2015
 */

using UnityEngine;
using System.Collections;

public class BottonMain : MonoBehaviour {
	public GameObject MenuSecond;
	public void Jugar(bool actv){
		if(actv == true){Application.LoadLevel(1);}
	}
	public void Salir(bool act){
		if(act == true){Application.Quit();
			Debug.Log("Quit enabled");}
	}
	public void Princi(bool acti){
		if(acti == true){Application.LoadLevel(0);}}
	public void ActUI(bool atv){
		if(atv == false){MenuSecond.SetActive(false);}
		else{MenuSecond.SetActive(true);}
	}
}
