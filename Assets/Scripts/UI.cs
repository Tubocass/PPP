using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public GameObject RollingBpaper;
	public GameObject RollingJpaper;
	private bool isPaperActive;


	public void CreateBPaper () {
		//Debug.Log ("Create paper object for button clicked " + name);

		if (!isPaperActive) {
			Instantiate (RollingBpaper);
			GameObject.Find ("Button B").GetComponentInChildren<Text> ().text = "Put Away";
			isPaperActive = true;
		} else {
			Debug.Log("Putting Away");
			Destroy (GameObject.FindWithTag ("Blunt"));
			GameObject.Find ("Button B").GetComponentInChildren<Text> ().text = "Prepare Blunt Paper";
			isPaperActive = false;
			}
	}

	public void CreateJPaper () {
		
		if (!isPaperActive) {
			Instantiate (RollingJpaper);
			GameObject.Find ("Button J").GetComponentInChildren<Text> ().text = "Put Away";
			isPaperActive = true;
			Debug.Log (isPaperActive);

		} else {
				Debug.Log ("Putting Away");
				Destroy (GameObject.FindWithTag ("Joint"));
				isPaperActive = false;
				GameObject.Find ("Button J").GetComponentInChildren<Text> ().text = "Prepare Joint Paper";
			}
		}

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
