using UnityEngine;
using System.Collections;

public class uiDisplay : MonoBehaviour {


	float minX, maxX, minY, maxY;

	public GameObject mana;
	public GameObject health; 

	// Use this for initialization
	void Start () {
		Vector3 posHealth = new Vector3(Input.mousePosition.x - Input.mousePosition.x + 50f , 
		                                Input.mousePosition.y - Input.mousePosition.y + 100f , 2f);

		Vector3 posMana = new Vector3(Input.mousePosition.x - Input.mousePosition.x + 160f , 
		                          Input.mousePosition.y - Input.mousePosition.y + 100f , 2f);


		health.transform.position = Camera.main.ScreenToWorldPoint(posHealth);
		mana.transform.position = Camera.main.ScreenToWorldPoint(posMana);


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
