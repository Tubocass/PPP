using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Lungs : MonoBehaviour 
{
//	enum State{In, Out, Hold, Breathe}
//	State currentState = State.Breathe;
//	State MyState{
//		get{return currentState;}
//		set{}
//	}
//	int breatheHash = Animator.StringToHash("Breathe");
//	int inhaleHash = Animator.StringToHash("Inhale");
//	int coughHash = Animator.StringToHash("Cough");
//	int exhaleHash = Animator.StringToHash("Exhale");
	Animator anim;
	bool cough = false, canInhale = true;
	public UnityEvent click; 
	int score;
	[SerializeField] float playTime, totalTime;
	AnimatorClipInfo[] animationClip;
	AnimatorStateInfo animationInfo;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

//	void ChangeState(State newState)
//	{
//		
//		currentState = newState;
//	}
//	void ExitState(State currState)
//	{
//		switch(currState)
//		{
//		case State.Hold:
//			
//			break;
//		}
//	}
	IEnumerator InhaleRoutine()
	{
		yield return new WaitForSeconds(4.2f);
		canInhale = true;
	}
	public void Inhale()
	{
		if(canInhale)
		{
			anim.SetTrigger("Inhale");
			anim.speed = .8f;
			StartCoroutine(InhaleRoutine());
			canInhale = false;
		}

	}
	public void HoldBreath()
	{
//		if(anim.GetCurrentAnimatorStateInfo(0).shortNameHash.Equals(inhaleHash))
//		{
			//anim.speed = 0;
//		}
	}

	public void Exhale()
	{
		anim.speed = 1;
		anim.SetTrigger("Exhale");
		//Debug.Log(""+playTime);
		//playTime = anim.GetCurrentAnimatorClipInfo(0)[0].clip.averageDuration;
		//playTime = 0;
		//totalTime = anim.GetCurrentAnimatorClipInfo(0)[0].clip.length;
	}

	public void Cough()
	{
		//anim.speed = 1;
		anim.SetBool("Cough", true);
	}
	public void ResetCough()
	{
		anim.SetBool("Cough", false);
		canInhale = true;
	}

	void OnMouseDown()
	{
		Exhale();
		click.Invoke();
	}
}
