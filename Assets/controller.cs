using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

// Use this for initialization
	public Texture btnTexture;
	Animator animator;

	void Start () {
		Debug.Log("checking this");
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 1);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 2);
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 3);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 4);
		}

		/*
		if (!Input.GetKey (KeyCode.DownArrow) && !Input.GetKey (KeyCode.LeftArrow)
			&& !Input.GetKey (KeyCode.RightArrow) && !Input.GetKey (KeyCode.UpArrow)) {
			animator.SetInteger("Direction" , 0);
		}
		*/

	}


	void OnGUI() {
		/*
		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		*/
		if (GUI.RepeatButton (new Rect (95, 30, 50, 30), "up")) {
			transform.Translate (Vector3.up * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 1);
		}
		
		if (GUI.RepeatButton (new Rect (95, 90, 50, 30), "down")) {
			transform.Translate (Vector3.down * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 3);
		}

		if (GUI.RepeatButton (new Rect (30, 60, 50, 30), "left")) {
			transform.Translate (Vector3.left * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 4);
		}

		if (GUI.RepeatButton (new Rect (170, 60, 50, 30), "right")) {
			transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 2);
		}

		if (GUI.Button (new Rect (1120, 40, 100, 60), "A")) {
			transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 2);
		}

		if (GUI.Button (new Rect (1000, 120, 100, 60), "B")) {
			transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			animator.SetInteger("Direction" , 2);
		}





	}


}
