using UnityEngine;
using System.Collections;

public class Mame_oti : MonoBehaviour {
	public int speed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.right.normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
