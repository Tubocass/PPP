using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitBar : MonoBehaviour 
{
	public GameObject hitBar, perfectBar;
	public float speed = 4f;
	[SerializeField] ScoreUI ui;
	[SerializeField] AudioSource coughSound;
	Vector3 hitBarStart;
	[SerializeField]ButtonHold button;
	bool cough = false;
	//Image image;
	float length = 0, endPoint, perfectPoint;
	float penalties, perfectLength;
	int score;

	void Awake()
	{
		Vector3 hitPosition = hitBar.transform.localPosition;
		hitBarStart = hitPosition;
		//image = GetComponent<Image>();
		length = GetComponent<RectTransform>().rect.width;
		perfectLength = length * .8f;
		endPoint = hitPosition.x + length-20;
		perfectPoint = hitPosition.x + perfectLength;
		perfectBar.transform.localPosition += new Vector3(perfectLength,0,0);
	}
		
	public void Inhale()
	{
		if(!button.ableToHit)
		{
			return;
		}
		Vector3 hitPosition = hitBar.transform.localPosition;
		if(hitPosition.x>perfectPoint)
		{
			cough = true;
		}
		if(hitBar.transform.localPosition.x<endPoint)
		{
			hitBar.transform.localPosition = Vector3.MoveTowards(hitPosition, new Vector3(endPoint,hitPosition.y,hitPosition.z), speed);
		}else{
			//if(GetComponent<ButtonHold>().ableToHit)
			//Release();
			button.onRelease.Invoke();
			button.ableToHit = false;
		}
	}
	public void Release()
	{
		if(!button.ableToHit)
		{
			return;
		}
		float percentage;
		if(cough)
		{
			Debug.Log("Cough... cough");
			//play cough audio
			coughSound.Play();
			percentage = .8f;
		}else {
			percentage = (hitBar.transform.localPosition.x - hitBarStart.x)/perfectLength;
		}

		score = (int)(percentage*420);
		ui.AddScore(score);
		Reset();
	}

	void Reset()
	{
		hitBar.transform.localPosition = hitBarStart;
		cough = false;
	}

}
