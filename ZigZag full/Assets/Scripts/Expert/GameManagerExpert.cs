using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerExpert : MonoBehaviour {

	public static GameManagerExpert instance;
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
		UiManagerExpert.instance.GameStart ();
		ScoreManagerExpert.instance.StartScore ();
		GameObject.Find ("PlatformSpawner").GetComponent<PlatformSpawnerExpert> ().StartSpawningPlatforms();
	}

	public void GameOver()
	{
		ScoreManagerExpert.instance.StopScore ();
		UiManagerExpert.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
		gameOver = true;
	}
}
