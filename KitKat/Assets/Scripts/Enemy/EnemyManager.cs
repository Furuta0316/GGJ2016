using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	public int MaxEnemyCount;//敵の最大数
	public int ClearCount;//クリア条件の敵の数
	public int EnemyCount;//敵の現在の数
	public bool Line1;//ライン1にいるか？
	public bool Line2;//ライン2にいるか？
	public bool Line3;//ライン3にいるか？
	// Use this for initialization
	void Start () {
		//初期状態取得
		EnemyCount = getEnemyCount ();
		LineBoolChange ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		//更新処理
		EnemyCount = getEnemyCount ();
		LineBoolChange ();
	}
	int getEnemyCount(){//現在の出現数
		int count = 0;
		GameObject[] Enemys = GameObject.FindGameObjectsWithTag ("Enemy");//enemy全体
		foreach (GameObject enemy in Enemys) {
			++count;//enemyの数だけ足す

		}
		return count;
	}
	void LineBoolChange(){//lineにいるか判断
		//各ラインいる数
		int Line1Count = 0;
		int Line2Count = 0;
		int Line3Count = 0;
		GameObject[] Enemys = GameObject.FindGameObjectsWithTag ("Enemy");//enemy全体
		foreach (GameObject enemy in Enemys) {
			Enemy1 enemy1 = enemy.GetComponent<Enemy1> ();
			if(enemy1.line==1){
				++Line1Count;
			}
			if(enemy1.line==2){
				++Line2Count;
			}
			if(enemy1.line==3){
				++Line3Count;
			}
		}

		if(Line1Count>0){
			Line1 = true;
		}
		if(Line2Count>0){
			Line2 = true;
		}
		if(Line3Count>0){
			Line3 = true;
		}
		if(Line1Count==0){
			Line1 = false;
		}
		if(Line2Count==0){
			Line2 = false;
		}
		if(Line3Count==0){
			Line3 = false;
		}
	}
	public void ReduceClearCount(){
		--ClearCount;//1減らす
	}
}
