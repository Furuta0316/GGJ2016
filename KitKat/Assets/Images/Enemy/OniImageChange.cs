using UnityEngine;
using System.Collections;

public class OniImageChange : MonoBehaviour {
	public SpriteRenderer rend;
	public Sprite[] Oni;
	int  time;
	int rand;
	public bool Walkf;
	public bool Atackf;
	public bool Standf;
	public bool Damagef;
//	public GameObject parent;
//	Enemy1 enemy;
	bool f;
	// Use this for initialization
	void Start () {
		time = 0;
		rend.sprite = Oni [0];
		//enemy = parent.GetComponent<Enemy1> ();
		f = false;
	}
	
	// Update is called once per frame
	void Update () {
		++time;
	//	Damage ();
		if(Walkf){
		Walk ();
		}
		if(Atackf){
			Atack ();
		}
		if(Standf){
			Stand ();
		}
		if (Damagef) {
			Damage ();
		}
	}
	void Change(){
		
	}
	int RandomF(int a,int b){
		int x = 0;
		x= Random.Range (a,b+1);
		return x;
	}
	public void Walk(){
		if(!f){
			time = 0;
			f = true;
		}
		if (f) {
			if (time > 0 && time < 7) {
				rend.sprite = Oni [0];
			}
			if (time >= 7 && time < 14) {
				rend.sprite = Oni [1];
			}
			if (time >= 14 && time < 21) {
				rend.sprite = Oni [2];
			}
			if (time >= 21 && time < 28) {
				rend.sprite = Oni [3];
			}
			if (time >= 28) {
				time = 0;
				f = false;
			}
		}
	}
	public void Stand(){
		rend.sprite = Oni [4];
	}
	public void Atack(){
		if(!f){
			time = 0;
			f = true;
		}
		if(f){
		if(time>0&&time<7){
			rend.sprite = Oni [5];
		}
		if (time >= 7 && time < 14) {
			rend.sprite = Oni [6];
		}
		if (time >= 14 && time < 21) {
			rend.sprite = Oni [7];
		}
		if(time>=21){
			time = 0;
				f = false;
		}
		}
	}
	public void Damage(){
		if(!f){
			time = 0;
			f = true;
		}
		if (f) {
			if (time > 0 && time < 7) {
				rend.sprite = Oni [8];
			}
			if (time >= 7 && time < 14) {
				rend.sprite = Oni [9];
			}
			if (time >= 14 && time < 21) {
				rend.sprite = Oni [10];
			}

			if (time >= 21) {
				time = 0;
				f = false;
			}
		}
	}
}
