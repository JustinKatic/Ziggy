using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour 
{

	public EventSystem eventSystem;		//Allows to get at the eventSystem
	public GameObject selectedObject;	//Gets the selected object

	private bool buttonSelected;		//Checked if button is selected

	void Update()
	{
		if (Input.GetAxisRaw ("Vertical") != 0 && buttonSelected == false)	
		{																		//Check to see if button is selected when you press Vertical keys up or down
			eventSystem.SetSelectedGameObject (selectedObject);					//If button is selected button selected is == true
			buttonSelected = true;
		}
	}
	private void OnDisable()
	{
		buttonSelected = false;													//Sets buttonSelected to false	
	}
}