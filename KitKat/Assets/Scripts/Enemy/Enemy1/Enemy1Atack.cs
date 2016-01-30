using UnityEngine;
using System.Collections;

public class Enemy1Atack : MonoBehaviour {
	public int time;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		--time;
		if(time < 0){
			Destroy (this.gameObject);
		}
	}
}
