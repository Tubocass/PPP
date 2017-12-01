using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log ("Level Load Request for: " + name);
		Application.LoadLevel (name);


	}

	public void QuitRequest(){
		Debug.Log ("Have a great day!");
	}

}
