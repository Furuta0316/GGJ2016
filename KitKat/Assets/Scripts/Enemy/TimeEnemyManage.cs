using UnityEngine;
using System.Collections;

public class TimeEnemyManage : MonoBehaviour {
    private System.DateTime StartTime;//ゲーム開始時間
	private System.DateTime Now;//現在時間
	private System.TimeSpan TotalTime;//経過時間
	public int time;//制限時間


	// Use this for initialization
	void Start () {
		StartTime = System.DateTime.Now;//開始時間取得
	}
	
	// Update is called once per frame
	void Update () {


	}
	void FixedUpdate(){
		Now = System.DateTime.Now;//現在時間取得
		TotalTime = Now-StartTime;//経過時間取得
		int TotalSecond = (int)TotalTime.TotalSeconds;//経過時間(秒)
		time=TotalSecond;
	}
}
