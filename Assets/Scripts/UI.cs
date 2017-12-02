using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public GameObject RollingBpaper;
	public GameObject RollingJpaper;
	public GameObject RollActionButton;
	public GameObject HintText;
	public GameObject Pinch;
	private bool isPaperActive;
	private bool isRollButtonActive = false;



	public void CreateBPaper () {
		//Debug.Log ("Create paper object for button clicked " + name);

		if (!isPaperActive) {
			Instantiate (RollingBpaper);
			GameObject.Find ("Button B").GetComponentInChildren<Text> ().text = "Put Away";

			GameObject.Find ("Button J").GetComponentInChildren<Text> ().text = "";
			GameObject Htext = Instantiate (HintText, new Vector3(150,70,0), Quaternion.identity);
			Htext.transform.SetParent (GameObject.FindWithTag ("Canvas").transform, false);

			Debug.Log ("created HintText");
			isPaperActive = true;
		} else {
			Debug.Log("Putting Away");
			DestroyImmediate (GameObject.FindWithTag ("Blunt"));
			DestroyImmediate (GameObject.FindWithTag ("Pinch"));
			DestroyImmediate (GameObject.FindWithTag ("HintText"));
			GameObject.Find ("Button B").GetComponentInChildren<Text> ().text = "Prepare Blunt Paper";
			GameObject.Find ("Button J").GetComponentInChildren<Text> ().text = "Prepare Joint Paper";

			isPaperActive = false;
			}
	}

	public void CreateJPaper () {
		
		if (!isPaperActive) {
			Instantiate (RollingJpaper);
			GameObject.Find ("Button J").GetComponentInChildren<Text> ().text = "Put Away";
			GameObject.Find ("Button B").GetComponentInChildren<Text> ().text = "";
			Debug.Log (isPaperActive);
			Instantiate (HintText);
			isPaperActive = true;

		} else {
				Debug.Log ("Putting Away");
				DestroyImmediate (GameObject.FindWithTag ("Joint"));
				DestroyImmediate (GameObject.FindWithTag ("Pinch"));
			DestroyImmediate (GameObject.FindWithTag ("HintText"));
				GameObject.Find ("Button J").GetComponentInChildren<Text> ().text = "Prepare Joint Paper";
				GameObject.Find ("Button B").GetComponentInChildren<Text> ().text = "Prepare Blunt Paper";
				isPaperActive = false;

			}
		}

	public void RollAction () {

		Debug.Log ("Destroy UI");
		DestroyImmediate (GameObject.FindWithTag ("Canvas"));

		DestroyImmediate (GameObject.FindWithTag ("Strain"));
		DestroyImmediate (GameObject.FindWithTag ("HintText"));
		DestroyImmediate (GameObject.FindWithTag ("UI"));







	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isPaperActive && GameObject.FindWithTag ("Pinch") && !isRollButtonActive) {
			GameObject.Find ("StartRollActionButton").SetActive (true);
			isRollButtonActive = true;

		} else {
			
		
	}
}
}
