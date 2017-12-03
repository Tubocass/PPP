using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmokingController : MonoBehaviour 
{
	public float speed = 4f;
	[SerializeField] ScoreUI ui;
	[SerializeField] AudioSource coughSound;
	[SerializeField] ButtonHold button;
	bool cough = false;
	float penalties;
	int score;

	void Release()
	{
		float percentage= 0;
		if(cough)
		{
			Debug.Log("Cough... cough");
			coughSound.Play();
			percentage = .8f;
		}else {
			//percentage = (hitBar.transform.localPosition.x - hitBarStart.x)/perfectLength;
		}

		score = (int)(percentage*420);
		ui.AddScore(score);
	}
}
