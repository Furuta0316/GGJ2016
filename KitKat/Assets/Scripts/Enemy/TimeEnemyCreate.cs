using UnityEngine;
using System.Collections;

public class TimeEnemyCreate : MonoBehaviour {
	TimeEnemyManage time;
	public int[] CreateTime;
	public GameObject Enemy;//生産する敵
	public GameObject[] spawPosition;
	public GameObject EnemyManager;
	EnemyManager emanage;
	public bool CreateFlag;
	Vector3 Position;
	int oldtime;
	// Use this for initialization
	void Start () {
		time = this.gameObject.GetComponent<TimeEnemyManage> ();
		emanage = EnemyManager.GetComponent<EnemyManager> ();
		CreateFlag = false;
		Position = spawPosition [1].transform.position+Vector3.down;
	}
	
	// Update is called once per frame
	void Update () {
		if(oldtime!=time.time){
			CreateFlag = false;
		}
		if(emanage.MaxEnemyCount>emanage.EnemyCount){
			for(int i = 0;i < CreateTime.Length;i++){
				if(i==1){
					Position=spawPosition [2].transform.position+Vector3.down;
				}
				if(i==0||i==3){
					Position=spawPosition [0].transform.position+Vector3.down;
				}
				if(i==2){
					Position=spawPosition [1].transform.position+Vector3.down;
				}
			if(time.time==CreateTime[i]){
					if(!CreateFlag){
						Instantiate (Enemy,Position,Quaternion.identity);
						CreateFlag = true;
					}
			 }

			}


		}

		oldtime = time.time;
	}
}
