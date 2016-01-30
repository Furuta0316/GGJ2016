using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {
	int  time;
	// Use this for initialization
	void Start () {
		time = 60;
	}
	
	// Update is called once per frame
	void Update () {
		--time;
		if(time<0){
			Destroy (this.gameObject);
		}
	}
}
