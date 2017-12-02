using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannabisDrag : MonoBehaviour {

	public GameObject CannaPrefab;
	private GameObject Cannabis;
	public int cannaCount;
	private Vector3 mousepos;
	private bool isMouseDrag;
	public Vector3 screenPosition;
	public Vector3 offset;
	public GameObject target;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		//Debug.Log (cannaCount);

		//Create code to only create cannabis pinch object when mouse is within range of Grinder

			



		if (Input.GetMouseButtonDown (0)) {
			mousepos = Input.mousePosition;
			mousepos.z = 900;
			mousepos = Camera.main.ScreenToWorldPoint (mousepos);

			if (cannaCount < 1) {
			

				if (!GameObject.Find ("RollingBPaper")) {

					Debug.Log ("Create pinch of weed");
					Cannabis = Instantiate (CannaPrefab, mousepos, Quaternion.identity) as GameObject;
				}
				cannaCount++;
				} else {
				Debug.Log ("You already have enough");

			}

		}

	}
}



	


