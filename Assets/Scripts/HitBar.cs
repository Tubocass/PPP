using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitBar : MonoBehaviour 
{
	public GameObject bar;
	bool isMouseover;
	Image image;

	void Awake()
	{
		image = GetComponent<Image>();
	}

	public void Update()
	{
		if(isMouseover && Input.GetMouseButton(0))
		bar.transform.localPosition += Vector3.right;
	}
	public void MouseOver()
	{
		isMouseover = true;
	}

}
