using UnityEngine;
using System.Collections;

public class SoyShot_oti : MonoBehaviour {
	public GameObject MameR;
	public GameObject MameB;
	public GameObject MameG;
	public float time;
	public int ShotColor;
	public Animator anim;
	private bool isRunning;
	public bool nageru;

	// Use this for initialization
	void Start () {
		//StartCoroutine ("Soy");
		anim.GetComponent<Animator>();
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
			if (nageru == true) {
				if (ShotColor == 1) {
					anim.SetTrigger ("throw");
					Instantiate (MameR, this.transform.position, this.transform.rotation);
				}
				if (ShotColor == 2) {
					anim.SetTrigger ("throw");
					Instantiate (MameB, this.transform.position, this.transform.rotation);
				}
				if (ShotColor == 3) {
					anim.SetTrigger ("throw");
					Instantiate (MameG, this.transform.position, this.transform.rotation);
				}
			}
			yield return new WaitForSeconds (time);

			isRunning = false;
		}
	}
}
