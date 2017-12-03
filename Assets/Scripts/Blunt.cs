using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blunt : MonoBehaviour 
{
	Animator anim;
	ParticleSystem smoke;

	void Awake()
	{
		smoke = GetComponentInChildren<ParticleSystem>();
		anim = GetComponent<Animator>();
		anim.Play("PuffAnim",0,0);
		anim.speed = 0;
	}

//	public void Smoke()
//	{
//		anim.SetBool("Smoke", true);
//	}
	public void Puff()
	{
		if(smoke.isStopped)
			smoke.Play();
		anim.speed = 0.5f;
	}
	public void EndPuff()
	{
		anim.speed = 0;
		smoke.Emit(8);
	}
}
