using UnityEngine;
using System.Collections;

public class Mame_oti : MonoBehaviour {
	public int speed;
	public float time;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (-500.0f, 250.0f, 0.0f, ForceMode.Force);
		//GetComponent<Rigidbody> ().velocity = transform.right.normalized * speed;
		Destroy (this.gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Enemy") {
			
			GameObject.Find ("Status").GetComponent<Score> ().kazu += 100;
		}
	}
}
