/* 
 * Script Restarter, viene por defecto en los Assets 2D, fue modificada para implementar
 * el sistema de replays, score y checkpoint.
 */ 

using System;
using UnityEngine;

namespace UnityStandardAssets._2D{
    public class Restarter : MonoBehaviour{
		scorev2 scer;
		Rigidbody2D RigPlayer;
		void Awake(){
			scer = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
			RigPlayer = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
		}
        private void OnTriggerEnter2D(Collider2D other){
            if (other.tag == "Player"){
                scer.restor -= 1;
                scer.score = 0;
                RigPlayer.transform.position = CheckPoint.GetActiveCheckPointPosition();
            }
        }
    }
}
