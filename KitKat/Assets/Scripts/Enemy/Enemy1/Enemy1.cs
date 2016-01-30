using UnityEngine;
using System.Collections;

public class Enemy1 : EnemyState {
	//赤鬼のスクリプト
	int initTime;//ノックバック時間の初期値	
	EnemyAtack  enemyAtack;//
	int DeviatTime;
	// Use this for initialization
	void Start () {
		PanelZSize = 5;
		getPosition();//初期座標取得
		speed = 3;//速さ設定
		HP=2;//HP設定
		NockBack = false;
		Escape = false;
		AtackFlag = false;
		NockBackTime = 60;//ノックバック時間の設定
		initTime=NockBackTime;
		enemyAtack = this.gameObject.GetComponent<EnemyAtack> (); 
		Deviated = false;
		DeviatTime=10;
	}

	// Update is called once per frame
	void Update () {
		//debug
		if(Input.GetKeyDown(KeyCode.A)){
			//Bend ();
			Escape = true;
			//AtackFlag=true;
		}
	}
	void FixedUpdate(){
		getPosition ();//座標更新
		if(!Escape){
		line = getLineNumber (Position);//行番更新
			}
		if(Escape){
			line = 0;
		}
		if(!NockBack&&!Escape){//仰け反ってない状態かつやられていない状態
			if(!AtackFlag){
		Move ();
			}
			if(AtackFlag){
				Atack ();
			}
		}
			//仰け反り
		if(NockBack&&!Escape){
			BendTimeReduce ();
		}

		if(HP<=0){
			Escape = true;
		}
		
		if(Escape){
			if(!Deviated){
				YMove ();
			}
			if(Deviated){
			EscapeRun ();
			}
		}
		//
		if(Position.x<-16){
			Destroy (this.gameObject);
		}
	}
	void Move(){//キャラの動き　真っ直ぐ
		transform.position = Position + Vector3.right * Time.deltaTime*speed;
	}
	void Bend(){//仰け反り
		
		NockBack = true;

	}
	void BendTimeReduce(){//
		--NockBackTime;
		if(NockBackTime<0){
			NockBackTime = initTime;//初期値設定
			NockBack = false;

		}
	}
	void ReduceHP(){//HPを1減らす
		--HP;
	}
	void EscapeRun(){//やられて逃げる時の動き
		//とりあえず来たレーンを走って戻る
		speed = 10;//走るため速く
		transform.position = Position + Vector3.left * Time.deltaTime*speed;
	}
	void Atack(){
		enemyAtack.enabled = true;//
	}
	void OnCollisionEnter(Collision col){
		if(col.collider.tag=="Soy"){//豆との当たり判定
			Bend();//仰け反り
			if(HP>=1){
			ReduceHP();
			}
		}

	}
	void YMove(){
		speed = 10;//走るため速く
		transform.position = Position + Vector3.forward * Time.deltaTime*speed;
		--DeviatTime;
		if(DeviatTime<0){
		Deviated = true;
		}
	}
	void OnBecameInvisible(){

	
		}
}
