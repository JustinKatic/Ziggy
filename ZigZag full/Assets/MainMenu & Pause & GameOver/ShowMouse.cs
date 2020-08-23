using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.None;					//unlock curser from middle of screen
		Cursor.visible = true;									// mouse pointer visible
	}
}
	

