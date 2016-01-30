using UnityEngine;
using System.Collections;

public class SoyShot_oti : MonoBehaviour {
	public GameObject Mame;
	public float time;
	public bool shot;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Soy");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator Soy(){
		if (shot = true) {
			while (true) {
				yield return new WaitForSeconds (time);
				Instantiate (Mame, this.transform.position, this.transform.rotation);
				yield return new WaitForSeconds (time);
			}
		}
	}
}
