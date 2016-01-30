using UnityEngine;
using System.Collections;
//新しいシーン切り替えを使うための宣言
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour {

	//エンディングを流す時間
	//public float endingTime_ = 3.0f;
	//スタッフロールのスライドスピード
	public float speed_ = 0.03f;
	public EventSceneTimer est;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (endingTime_ > Time.time) {//一定時間経過後するまで
			//スタッフロールをスライドさせる
			//this.transform.position.y += speed_;
			//↑のプログラムはエラーが出る
		transform.Translate(0,speed_,0);
		if (Input.GetMouseButtonDown (0)) {
			est.Skip ();
			//他スクリプトで実装済み。
			//SceneManager.LoadScene ("title");
		}
		//} else {//一定時間経過後
			//タイトル画面に戻るが、他のスクリプトで実装済み。
			//SceneManager.LoadScene("title");
		//}//
	
	}
}
