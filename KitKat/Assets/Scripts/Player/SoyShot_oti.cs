﻿using UnityEngine;
using System.Collections;

public class SoyShot_oti : MonoBehaviour {
	public GameObject MameR;
	public GameObject MameB;
	public GameObject MameG;
	public float time;
	public int ShotColor;
	private bool isRunning;

	// Use this for initialization
	void Start () {
		//StartCoroutine ("Soy");
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("Soy");
	}
	IEnumerator Soy(){
		while (true) {
			if (isRunning)
				yield break;
			isRunning = true;

			yield return new WaitForSeconds (time);
			if (ShotColor == 1) {
				Instantiate (MameR, this.transform.position, this.transform.rotation);
			}
			if (ShotColor == 2) {
				Instantiate (MameB, this.transform.position, this.transform.rotation);
			}
			if (ShotColor == 3) {
				Instantiate (MameG, this.transform.position, this.transform.rotation);
			}
			yield return new WaitForSeconds (time);

			isRunning = false;
		}
	}
}