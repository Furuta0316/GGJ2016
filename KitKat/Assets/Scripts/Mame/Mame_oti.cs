using UnityEngine;
using System.Collections;

public class Mame_oti : MonoBehaviour {
	public int speed;
	public float time;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.right.normalized * speed;
		Destroy (this.gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
