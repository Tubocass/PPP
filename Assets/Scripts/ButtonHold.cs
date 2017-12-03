using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
	public bool buttonPressed;
	public UnityEvent onClick;

	public void OnPointerDown(PointerEventData eventData)
	{
		buttonPressed = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		buttonPressed = false;
	}

	void Update()
	{
		if(buttonPressed)
		{
			onClick.Invoke();
		}
	}
}
