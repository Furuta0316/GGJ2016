using UnityEngine;
using System.Collections;

public class Player_oti : MonoBehaviour {

	private float sw;
	private float sh;
	private Vector3 touchPosition;
	private float x;
	public float z;
	private float X;
	private float Y;
	private float Z;

	//public GameObject Player;
	public int moveF = 0;
	public int moveP = 0;
	public float speed;
	public Transform P11;
	public Transform P12;
	public Transform P13;
	public Transform P21;
	public Transform P22;
	public Transform P23;
	public Transform P31;
	public Transform P32;
	public Transform P33;
	public Animator anim;

	public float time;

	// Use this for initialization
	void Start () {
		sw= Screen.width;
		sh= Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		if (moveF == 1) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P11.position, step);
			moveP = 1;
		}
		if (moveF == 2) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P21.position, step);
			moveP = 2;
		}
		if (moveF == 3) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P31.position, step);
			moveP = 3;
		}
		if (moveF == 4) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P12.position, step);
			moveP = 4;
		}
		if (moveF == 5) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P22.position, step);
			moveP = 5;
		}
		if (moveF == 6) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P32.position, step);
			moveP = 6;
		}
		if (moveF == 7) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P13.position, step);
			moveP = 7;
		}
		if (moveF == 8) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P23.position, step);
			moveP = 8;
		}
		if (moveF == 9) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, P33.position, step);
			moveP = 9;
		}

		if (GameObject.Find ("Player").GetComponent<SoyShot_oti> ().nageru == false) {
			time += Time.deltaTime;
			if (time >= 1.0f) {
				GameObject.Find ("Player").GetComponent<SoyShot_oti> ().nageru = true;
			}
		} else {
			time = 0;
		}
	}

	void OnEnable ()
	{
		TouchManager.Instance.FlickStart += OnFlickStart;
	}
	void OnDisable ()
	{
		TouchManager.Instance.FlickStart -= OnFlickStart;
	}

	void OnFlickStart (object sender, FlickEventArgs e)
	{
		if (moveP == 1) {
			if (e.Direction.ToString () == "Down") {
				GameObject.Find ("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 4;
			}
			if (e.Direction.ToString () == "Right") {
				GameObject.Find ("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 2;
			}
		}
		if (moveP == 2) {
			if (e.Direction.ToString () == "Down") {
				GameObject.Find ("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 5;
			}
			if (e.Direction.ToString () == "Right") {
				GameObject.Find ("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 3;
			}
			if (e.Direction.ToString () == "Left") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 1;
			}
		}
		if (moveP == 3) {
			if (e.Direction.ToString () == "Down") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 6;
			}
			if (e.Direction.ToString () == "Left") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 2;
			}
		}
		if (moveP == 4) {
			if (e.Direction.ToString () == "Up") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 1;
			}
			if (e.Direction.ToString () == "Down") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 7;
			}
			if (e.Direction.ToString () == "Right") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 5;
			}
		}
		if (moveP == 5) {
			if (e.Direction.ToString () == "Up") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 2;
			}
			if (e.Direction.ToString () == "Down") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 8;
			}
			if (e.Direction.ToString () == "Right") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 6;
			}
			if (e.Direction.ToString () == "Left") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 4;
			}
		}
		if (moveP == 6) {
			if (e.Direction.ToString () == "Up") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 3;
			}
			if (e.Direction.ToString () == "Down") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 9;
			}
			if (e.Direction.ToString () == "Left") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 5;
			}
		}
		if (moveP == 7) {
			if (e.Direction.ToString () == "Up") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 4;
			}
			if (e.Direction.ToString () == "Right") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 8;
			}
		}
		if (moveP == 8) {
			if (e.Direction.ToString () == "Up") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 5;
			}
			if (e.Direction.ToString () == "Right") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 9;
			}
			if (e.Direction.ToString () == "Left") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 7;
			}
		}
		if (moveP == 9) {
			if (e.Direction.ToString () == "Up") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 6;
			}
			if (e.Direction.ToString () == "Left") {
				GameObject.Find("Player").GetComponent<SoyShot_oti> ().nageru = false;
				anim.SetTrigger ("move");
				moveF = 8;
			}
		}
	}
}
