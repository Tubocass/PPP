using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitBar : MonoBehaviour 
{
	public GameObject hitBar, perfectBar;
	public float speed = 4f;
	bool isMouseover, cough = false;
	//Image image;
	float length = 0, endPoint, perfectPoint;

	void Awake()
	{
		Vector3 hitPosition = hitBar.transform.localPosition;
		//image = GetComponent<Image>();
		length = GetComponent<RectTransform>().rect.width;
		endPoint = hitPosition.x + length-20;
		perfectPoint = hitPosition.x + length * .8f;
		perfectBar.transform.localPosition += new Vector3(length * .8f,0,0);
	}

//	public void Update()
//	{
//		Vector3 hitPosition = hitBar.transform.localPosition;
//		if(isMouseover && Input.GetMouseButton(0))
//		{
//			if(hitBar.transform.localPosition.x<endPoint)
//			{
//				hitBar.transform.localPosition = Vector3.MoveTowards(hitPosition, new Vector3(endPoint,hitPosition.y,hitPosition.z), speed);
//				//hitPosition += Vector3.right;
//			}
//			if(hitPosition.x>perfectPoint)
//			{
//				cough = true;
//			}
//		}
//	}
	public void MouseOver()
	{
		Vector3 hitPosition = hitBar.transform.localPosition;

		if(hitBar.transform.localPosition.x<endPoint)
		{
			hitBar.transform.localPosition = Vector3.MoveTowards(hitPosition, new Vector3(endPoint,hitPosition.y,hitPosition.z), speed);
		}

		if(hitPosition.x>perfectPoint)
		{
			cough = true;
		}
	}

}
