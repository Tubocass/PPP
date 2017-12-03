using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
	public bool buttonPressed;
	public UnityEvent onClick , onHold, onRelease;

	public void OnPointerDown(PointerEventData eventData)
	{
		buttonPressed = true;
		onClick.Invoke();
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		buttonPressed = false;
		onRelease.Invoke();
	}

	void Update()
	{
		if(buttonPressed)
		{
			onHold.Invoke();
		}
	}
}
