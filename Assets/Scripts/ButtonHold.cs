using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
	public bool buttonPressed, ableToHit = true;
	public UnityEvent onClick , onHold, onRelease;

	public void OnPointerDown(PointerEventData eventData)
	{
		buttonPressed = true;
		onClick.Invoke();
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		buttonPressed = false;
		if(ableToHit)
		{
			onRelease.Invoke();
		}
		ableToHit = true;
	}

	void Update()
	{
		if(buttonPressed)
		{
			if(onHold !=null)
			onHold.Invoke();
		}
	}
}
