using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerEasy : MonoBehaviour {

	public static GameManagerEasy instance;
	public bool gameOver;

	void Awake()
	{
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () 
	{
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartGame()
	{
		UiManagerEasy.instance.GameStart ();
		ScoreManagerEasy.instance.StartScore ();
		GameObject.Find ("PlatformSpawner").GetComponent<PlatformSpawnerEasy> ().StartSpawningPlatforms();
	}

	public void GameOver()
	{
		ScoreManagerEasy.instance.StopScore ();
		UiManagerEasy.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
		gameOver = true;


	}
}
