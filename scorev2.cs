/* 
 * Script scorev2, lleva la cuenta de las vidas y puntos obtenidos por el player,
 * y lo implementa en un UI-Text e UI-Image de la interfaz.
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class scorev2 : MonoBehaviour {
	public int score;
	//public Text mytex;
	//public Image restor1;
	//public Image restor2;
	//public Image restor3;
	public int restor = 8;
	//public Rigidbody2D thisRigidbody;

	//void Awake(){thisRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();}

	void Update(){
		//mytex.text = "Crystals: " + score;
		if(restor == 7 || restor == 5 || restor == 3 || restor == 1){
            score = 0; 
            restor -= 1;
        }
		else if(restor == 0){
            SceneManager.LoadScene(3);
        }
	}
}
