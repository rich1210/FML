using UnityEngine;
using System.Collections;

public class merchantMenu : MonoBehaviour {

	public GameObject menu_obj;
	public GameObject[] stuff = new GameObject[5];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "mainChar") {
			Debug.Log("ENTER!");
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "mainChar") {
			if (Input.GetKey (KeyCode.Space)) {
				menu_obj.transform.position = new Vector3(transform.position.x, transform.position.y-0.3f, -9);
			}

			if(Input.GetKey (KeyCode.Escape)) {
				Debug.Log("testing!");
				menu_obj.transform.position = new Vector3(transform.position.x, transform.position.y-0.3f, -15);
			}
		}
	}


	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.tag == "mainChar") {
			Debug.Log("EXIT!");
		}
	}
}
