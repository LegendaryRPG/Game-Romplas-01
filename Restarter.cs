/* Script Restarter, viene por defecto en los Assets 2D, fue modificada para implementar
 * el sistema de replays, score y checkpoint.
 * 
 * Creada por Ezequiel Merino, by Legendary Rpg en MonoDevelop 4.0/Unity 5.2 @2015
 */ 

using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour{
		scorev2 scer;
		void Awake(){
			scer = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
		}
    private void OnTriggerEnter2D(Collider2D other){
			if (other.tag == "Player"){scer.restor -=1; scer.score =0;
				scer.thisRigidbody.transform.position = CheckPoint.GetActiveCheckPointPosition();}}
  }
}
