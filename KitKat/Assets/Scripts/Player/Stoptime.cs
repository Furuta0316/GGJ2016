using UnityEngine;
using System.Collections;

public class Stoptime : MonoBehaviour {
	public int stop;

	private float time;
	private float MTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (stop == 1) {
			time += Time.deltaTime;
			if (time >= 1.0f) {
				GameObject.Find ("Player").GetComponent<Player_oti> ().enabled = true;
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().enabled = true;
				GameObject.Find ("Status").GetComponent<Huku> ().HON = false;
				MTime += Time.deltaTime;
				if (MTime >= 1.0f) {
					GameObject.Find("Player").GetComponent<BoxCollider> ().enabled = true;
					stop = 0;
				}
			}
		}
		if (stop == 2) {
			time += Time.deltaTime;
			if (time >= 5.0f) {
				GameObject.Find("Player").GetComponent<Player_oti> ().enabled = true;
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().enabled = true;
				GameObject.Find ("Status").GetComponent<Huku> ().HON = false;
				MTime += Time.deltaTime;
				if (MTime >= 1.0f) {
					GameObject.Find("Player").GetComponent<BoxCollider> ().enabled = true;
					stop = 0;
				}
			}
		}
		if (stop == 3) {
			GameObject.Find("Player").GetComponent<Player_oti> ().enabled = true;
			GameObject.Find("Player").GetComponent<SoyShot_oti> ().enabled = true;
			time += Time.deltaTime;
			if (time >= 3.0f) {
				GameObject.Find ("Player").GetComponent<BoxCollider> ().enabled = true;
				stop = 0;
			} else {
				GameObject.Find("Player").GetComponent<BoxCollider> ().enabled = false;
			}
		}
	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Enemy") {
			Destroy (c.gameObject);
			GameObject.Find("Player").GetComponent<Player_oti> ().enabled = false;
			GameObject.Find("Player").GetComponent<SoyShot_oti> ().enabled = false;
			GameObject.Find("Player").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("Status").GetComponent<Huku> ().HON = true;
			GameObject.Find ("Status").GetComponent<Score> ().Perfect = true;
			stop = 1;
			time = 0;
			MTime = 0;
		}
		if (c.gameObject.tag == "EnemyAttack") {
			Destroy (c.gameObject);
			GameObject.Find("Player").GetComponent<Player_oti> ().enabled = false;
			GameObject.Find("Player").GetComponent<SoyShot_oti> ().enabled = false;
			GameObject.Find("Player").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("Status").GetComponent<Huku> ().HON = true;
			GameObject.Find ("Status").GetComponent<Score> ().Perfect = true;
			stop = 2;
			time = 0;
			MTime = 0;
		}
	}
}
