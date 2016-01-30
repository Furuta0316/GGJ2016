using UnityEngine;
using System.Collections;

public class EnemyCreate : MonoBehaviour {
	public GameObject SpawLine1;//line1生産場所
	public GameObject SpawLine2;//line2生産場所
	public GameObject SpawLine3;//line3生産場所
	public GameObject enemy;//生産する敵
	public GameObject enemyManager;//敵の管理
 EnemyManager emanage;

	bool create;
	// Use this for initialization
	void Start () {
		enemyManager = GameObject.Find ("EnemyManager");//object指定
		emanage=enemyManager.GetComponent<EnemyManager>();
		create= true;//生産可能である
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		Vector3 position;//生成場所
		if(emanage.ClearCount>=0){
			if(create){
		//	Instantiate (enemy,position,Quaternion.identity);
			emanage.ReduceClearCount ();//カウントを減らす
				create = false;//生成不可
			}
		}
	}
}
