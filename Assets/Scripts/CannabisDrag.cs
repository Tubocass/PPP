using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannabisDrag : MonoBehaviour {

	public GameObject CannaPrefab;
	public GameObject PapePrefab;
	private GameObject Cannabis;
	public int cannaCount;
	private Vector3 mousepos;
	private bool isMouseDrag;
	public Vector3 screenPosition;
	public Vector3 offset;
	public GameObject target;
	public Transform chicken;
	Vector3 offSet;



	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		//Debug.Log (cannaCount);

		//Create code to only create cannabis pinch object when mouse is within range of Grinder

		if (Input.GetMouseButtonDown (0)) {
			if (!GameObject.FindWithTag ("Pinch")) {
				
			mousepos = Input.mousePosition;
			mousepos.z = 900;
			mousepos = Camera.main.ScreenToWorldPoint (mousepos);

				if (GameObject.FindWithTag ("Blunt") || GameObject.FindWithTag ("Joint") ) {
					//if (mousepos == GameObject.Find ("Pinch").GetComponent<SpriteRenderer> ().bounds.center) {

						Debug.Log ("Create pinch of weed");
						Cannabis = Instantiate (CannaPrefab, mousepos, Quaternion.identity) as GameObject;
					//}

				} else {
				Debug.Log ("Where's the papes?");
				}
			} else {
				Debug.Log ("Already got enough bruh");
				}
				}
	}
}
