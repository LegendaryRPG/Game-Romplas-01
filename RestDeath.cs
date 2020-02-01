using UnityEngine;

public class RestDeath : MonoBehaviour{

    scorev2 scer;
    Rigidbody2D RigPlayer;
    Animator AnimPlayer;

    void Awake(){
        scer = GameObject.FindGameObjectWithTag("DataBase").GetComponent<scorev2>();
        RigPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        AnimPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            AnimPlayer.SetBool("Death",true);
            scer.restor -= 1;
            scer.score = 0;
        }
    }

    void Recontinue(){
        AnimPlayer.SetBool("Death",false);
        RigPlayer.transform.position = CheckPoint.GetActiveCheckPointPosition();
    }

}
