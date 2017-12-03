using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lungs : MonoBehaviour 
{
	Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	public void Inhale()
	{
		anim.SetTrigger("Inhale");
	}

	public void Exhale()
	{
		anim.SetTrigger("Exhale");
	}

}
