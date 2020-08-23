using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerHard : MonoBehaviour {

	public static GameManagerHard instance;
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
		UiManagerHard.instance.GameStart ();
		ScoreManagerHard.instance.StartScore ();
		GameObject.Find ("PlatformSpawner").GetComponent<PlatformSpawnerHard> ().StartSpawningPlatforms();
	}

	public void GameOver()
	{
		ScoreManagerHard.instance.StopScore ();
		UiManagerHard.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
		gameOver = true;
	}
}
