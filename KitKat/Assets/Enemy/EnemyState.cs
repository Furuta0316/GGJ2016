using UnityEngine;
using System.Collections;

public class EnemyState : MonoBehaviour {
	public int PanelZSize;//1マスの幅
	public int PanelXSize;//1マスの長さ
	public int line;//敵のいる行(ライン)
	public int column;//敵のいる列
	protected int HP;//ヒットポイント
	protected int speed;//速さ
	protected Vector3 Position;//現在座標
	protected bool NockBack;//ノックバック
	protected int NockBackTime;//ノックバック時間
	protected bool Escape;//逃げる(やられた)
	protected bool AtackFlag;//攻撃するフラグ
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void FixedUpdate(){
		
	}
	public void getPosition(){
		Position = transform.position ;// 座標取得
	}
	public int getLineNumber(Vector3 pos){//行番号取得
		if(pos.z>PanelZSize/2&&pos.z<PanelZSize+PanelZSize/2){
			return 1;
		}
		if(pos.z>-PanelZSize/2&&pos.z<PanelZSize/2){
			return 2;
		}
		if(pos.z<-PanelZSize/2&&pos.z>-PanelZSize-PanelZSize/2){
			return 3;
		}
		return 0;
	}
}
