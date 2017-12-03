using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blunt : MonoBehaviour 
{
	Animator anim;

	void Awake()
	{
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
		anim.speed = 0.5f;
	}
	public void EndPuff()
	{
		anim.speed = 0;
	}
}
