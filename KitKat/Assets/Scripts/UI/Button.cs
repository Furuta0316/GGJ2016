using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeR(){
		GameObject.Find ("Player").GetComponent<SoyShot_oti> ().ShotColor = 1;
	}
	public void ChangeB(){
		GameObject.Find ("Player").GetComponent<SoyShot_oti> ().ShotColor = 2;
	}
	public void ChangeG(){
		GameObject.Find ("Player").GetComponent<SoyShot_oti> ().ShotColor = 3;
	}
	public void huku(){
		GameObject.Find ("Player").GetComponent<Stoptime> ().stop = 3;
		GameObject.Find ("Status").GetComponent<Huku> ().Change = false;
	}
}
