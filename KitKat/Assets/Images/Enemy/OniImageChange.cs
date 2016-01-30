using UnityEngine;
using System.Collections;

public class OniImageChange : MonoBehaviour {
	public Sprite[] Oni;
	int rand;
	// Use this for initialization
	void Start () {
		rand = RandomF (0, 2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	int RandomF(int a,int b){
		int x = 0;
		x= Random.Range (a,b+1);
		return x;
	}
}
