using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blunt : MonoBehaviour 
{
	public GameObject hitBar, perfectBar;
	public float speed = 4f;
	[SerializeField]ButtonHold button;
	Animator anim;
	ParticleSystem smoke;
	Vector3 hitBarStart;
	bool cough = false, ableToHit = true;
	[SerializeField] float length = 0, perfectLength, endPoint, perfectPoint;
	//int score, penalties;

	void Awake()
	{
		smoke = GetComponentInChildren<ParticleSystem>();
		anim = GetComponent<Animator>();
		anim.Play("PuffAnim",0,0);
		anim.speed = 0;

		Vector3 hitPosition = hitBar.transform.localPosition;
		hitBarStart = hitPosition;
		//length = GetComponent<RectTransform>().rect.width;
		//perfectLength = length * .8f;
		endPoint = hitPosition.x - length;
		perfectPoint = hitPosition.x - perfectLength;
		perfectBar.transform.localPosition -= new Vector3(perfectLength,0,0);
	}

//	public void Smoke()
//	{
//		anim.SetBool("Smoke", true);
//	}
	public void Puff()
	{
		if(ableToHit)
		{
			if(smoke.isStopped)
				smoke.Play();
			
			anim.speed = 0.5f;

			Vector3 hitPosition = hitBar.transform.localPosition;
			if(hitPosition.x<perfectPoint)
			{
				cough = true;
			}
			if(hitBar.transform.localPosition.x>endPoint)
			{
				hitBar.transform.localPosition = Vector3.MoveTowards(hitPosition, new Vector3(endPoint,hitPosition.y,hitPosition.z), speed*.1f);
			}else{
				//if(GetComponent<ButtonHold>().ableToHit)
				//Release();
				button.onRelease.Invoke();
				button.ableToHit = false;
				ableToHit = false;
			}
		}
	}
	public void EndPuff()
	{
		anim.speed = 0.1f;
		smoke.Emit(8);

		float percentage;
		if(cough)
		{
			Debug.Log("Cough... cough");
			//play cough audio
			//coughSound.Play();
			percentage = .8f;
		}else {
			percentage = (hitBar.transform.localPosition.x - hitBarStart.x)/perfectLength;
		}

//		score = (int)(percentage*420);
//		ui.AddScore(score);
//		Reset();
	}
}
