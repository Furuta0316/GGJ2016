using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public bool Perfect;
	public Text Point;
	public int kazu;


	// Use this for initialization
	void Start () {
		Perfect = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		Point.text = "Score : " + kazu.ToString ();
	}
}
