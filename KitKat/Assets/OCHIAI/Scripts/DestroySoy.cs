using UnityEngine;
using System.Collections;

public class DestroySoy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		//void OnTrrigerEnter(Collider c){
		if (c.gameObject.tag == "Soy") {
			Destroy (c.gameObject);
		}
	}
}
