using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {
	public AudioSource audio;
	public AudioClip gameover;
	public GameObject GameOverSE;
	GameObject goal;
	bool flag;
	// Use this for initialization
	void Start () {
		flag = false;
		goal = GameObject.Find ("GameOver");
	}
	
	// Update is called once per frame
	void Update () {
		serch ();

	}
	void serch(){
		GameObject[] Enemys = GameObject.FindGameObjectsWithTag ("Enemy");//enemy全体
		foreach (GameObject enemy in Enemys) {
			if(enemy.transform.position.x>goal.transform.position.x){
				audio.mute = true;
				if(!flag){
					Instantiate (GameOverSE,Vector3.zero,Quaternion.identity);
					SceneChanger.Manager.AddScene (SceneChanger.SceneName.GameOver);
					flag = true;
				}
			
			}
		}
	}
}
