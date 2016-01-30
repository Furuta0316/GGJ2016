using UnityEngine;
using System.Collections;

public class GameOver_scene1 : MonoBehaviour {
	public GameObject GameOverSE;
	GameObject goal;
	public bool flag;
	// Use this for initialization
	void Start () {
		flag = false;
		goal = GameObject.Find ("GameOver");
	}
	
	// Update is called once per frame
	void Update () {
		if(!flag){
		if(this.gameObject.transform.position.x>goal.transform.position.x){
			Instantiate (GameOverSE,Vector3.zero,Quaternion.identity);
				flag = true;
		}
		}
	}


}
