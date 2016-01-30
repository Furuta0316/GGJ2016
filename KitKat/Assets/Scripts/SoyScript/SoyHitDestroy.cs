using UnityEngine;
using System.Collections;

public class SoyHitDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "Enemy") {//豆との当たり判定
			Destroy (this.gameObject);//　鬼と接触で豆を消す
		}
	}
}
