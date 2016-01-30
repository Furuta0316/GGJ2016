using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Huku : MonoBehaviour {
	public bool Change;
	public bool HON;
	public GameObject HukuOn;
	public GameObject HukuNo;
	public GameObject Hukunasi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Change == true) {
			if (HON == true) {
				HukuOn.SetActive (true);
				HukuNo.SetActive (false);
				Hukunasi.SetActive (false);

			}
			if (HON == false) {
				HukuOn.SetActive (false);
				HukuNo.SetActive (false);
				Hukunasi.SetActive (true);

			}
		}
		if (Change == false) {
			HukuOn.SetActive (false);
			HukuNo.SetActive (true);
			Hukunasi.SetActive (false);
		}
	}
}
