using UnityEngine;
using System.Collections;

public class EnemyState : MonoBehaviour {
	public int line;//敵のいる行(ライン)
	public int column;//敵のいる列
	protected int HP;//ヒットポイント
	public Vector3 Position;//現在座標
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		getPosition();//座標更新
		line = getLineNumber(Position);//行番更新
	}
	void getPosition(){
		Position = transform.position ;// 座標取得
	}
	int getLineNumber(Vector3 pos){//行番号取得
		if(pos.z>2.5f&&pos.z<7.5f){
			return 1;
		}
		if(pos.z>-2.5f&&pos.z<2.5f){
			return 2;
		}
		if(pos.z<-2.5f&&pos.z>-7.5f){
			return 3;
		}
		return 0;
	}
}
