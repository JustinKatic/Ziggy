using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour 


{
	public void NewGameButton (string newGameLevel)
	{
		SceneManager.LoadScene (newGameLevel);		//If NewGameButton pushed load new scene (PlayingGameScene)
	}



	public void ExitGameButton()
	{
		Application.Quit ();						//If ExitGameButton pushed Quit out of game
	}
}

