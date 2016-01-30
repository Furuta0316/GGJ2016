using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	public int MaxEnemyCount;//敵の最大数
	public int ClearCount;//クリア条件の敵の数
	public int EnemyCount;//敵の現在の数
	public bool Rine1;//ライン1にいるか？
	public bool Rine2;//ライン2にいるか？
	public bool Rine3;//ライン3にいるか？
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int getEnemyCount(){
		int count = 0;
		GameObject[] Enemys = GameObject.FindGameObjectsWithTag ("Enemy");//enemy全体
		foreach (GameObject enemy in Enemys) {
			++count;

		}
		return count;
	}
}
