/* Script scorev1, gemela de scorev2, utilizada para utilizar sus datos en otro
 * level, conservando los datos del level anterior.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.3.1 @2015
 */ 

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorev1 : MonoBehaviour {
	public int score;
	public int score2;
	public Text mytex;
	public Image restor1;
	public Image restor2;
	public Image restor3;
	scorev2 scorv2;

	void Awake(){
		scorv2 = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
	}

	void Update () {
		score = scorv2.score;
		score2 = scorv2.reint;
		mytex.text = "Crystals: "+score;
		if(score2 == 6){restor1.enabled = false;}	
		else if(score2 == 4){restor1.enabled = false; restor2.enabled = false;}
		else if(score2 == 2){restor1.enabled = false; restor2.enabled = false; restor3.enabled = false;}
	}
}
