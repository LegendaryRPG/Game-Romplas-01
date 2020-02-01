/* Script CheckPoint fue creada por Santi Andrade
 * santiandrade.github.io/Unity-Creating-a-checkpoints-system/
 */

using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {
	#region Public Variables
	
	/// <summary>
	/// Indicate if the checkpoint is activated
	/// </summary>
	public bool Activated = false;
	public Sprite ActivT;
	public Sprite ActivF;
	#endregion
	
	#region Private Variables
	
	private Animator thisAnimator;
	SpriteRenderer Spriter;
	#endregion
	
	#region Static Variables
	
	/// <summary>
	/// List with all checkpoints objects in the scene
	/// </summary>
	public static GameObject[] CheckPointsList;
	
	#endregion
	
	#region Static Functions
	
	/// <summary>
	/// Get position of the last activated checkpoint
	/// </summary>
	/// <returns></returns>
	public static Vector3 GetActiveCheckPointPosition(){
		// If player die without activate any checkpoint, we will return a default position
		Vector3 result = new Vector3(0, 0, 0);
		
		if (CheckPointsList != null){
			foreach (GameObject cp in CheckPointsList){
				// We search the activated checkpoint to get its position
				if (cp.GetComponent<CheckPoint>().Activated){
					result = cp.transform.position;
					break;}}}
		return result;
	}
	
	#endregion
	
	#region Private Functions
	
	/// <summary>
	/// Activate the checkpoint
	/// </summary>
	private void ActivateCheckPoint(){
		// We deactive all checkpoints in the scene
		foreach (GameObject cp in CheckPointsList){
			cp.GetComponent<CheckPoint>().Activated = false;
			cp.GetComponent<Animator>().SetBool("Active", false);}
		// We activated the current checkpoint
		Activated = true;
		thisAnimator.SetBool("Active", true);
	}
	
	#endregion
	
	void Start(){
		thisAnimator = GetComponent<Animator>();
		// We search all the checkpoints in the current scene
		CheckPointsList = GameObject.FindGameObjectsWithTag("CheckPoint");
		Spriter = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update(){
		if (Activated == true) {Spriter.sprite = ActivT;}
		else {Spriter.sprite = ActivF;}
	}
	
	void OnTriggerEnter2D(Collider2D other){
// If the player passes through the checkpoint, we activate it
		if (other.tag == "Player"){
			ActivateCheckPoint();}
	}
}

