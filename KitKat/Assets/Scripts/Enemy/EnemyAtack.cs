using UnityEngine;
using System.Collections;

public class EnemyAtack : MonoBehaviour {
	public GameObject AtackPrefab;//攻撃のprefab
	public int AtackLag;//攻撃するまでのラグ
	int init;
	GameObject enemy;
	// Use this for initialization
	void Start () {
		enemy = this.gameObject;
		init = AtackLag;
	}
	
	// Update is called once per frame
	void Update () {
		--AtackLag;
		if(AtackLag<0){
			Instantiate (AtackPrefab,enemy.transform.position+Vector3.right,Quaternion.identity);
			AtackLag = init;
			this.enabled=false;

		}
	}
}
