/* 
 * Script BottonMain, se utiliza principalmente para el OnClick,
 * de los botones del UI de Unity.
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BottonMain : MonoBehaviour {
	public GameObject MenuSecond;
	public AudioClip BotJug;
	public AudioClip BotExt;
	public AudioClip BotPrinc;
	public AudioClip BotCred;
	AudioSource playy;
	scorev2 sv2;

	void Awake(){
		sv2 = GameObject.FindGameObjectWithTag ("DataBase").GetComponent<scorev2> ();
		playy = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ();
	}

	public void Jugar(bool actv){
		if(actv == true){
            playy.clip = BotJug; playy.Play (); 
            SceneManager.LoadScene(1); 
            sv2.score = 0; 
            sv2.restor = 8;
        }
	}
    public void Salir(bool act){
        if (act == true){
            playy.clip = BotExt;
            playy.Play();
            Application.Quit();
            Debug.Log("Quit enabled");
        }
    }

	public void Princi(bool acti){
		if(acti == true){
            playy.clip = BotPrinc; 
            playy.Play ();
            SceneManager.LoadScene(0); 
            sv2.score = 0; 
            sv2.restor = 8;
        }
    }

	public void ActUI(bool atv){
		if(atv == false){
            MenuSecond.SetActive(false);
            playy.clip = BotCred;
            playy.Play ();
        }
		else{
            MenuSecond.SetActive(true);
            playy.clip = BotCred; 
            playy.Play ();
        }
	}
}
