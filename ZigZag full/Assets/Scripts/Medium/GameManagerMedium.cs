using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMedium : MonoBehaviour {

	public static GameManagerMedium instance;
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
		UiManagerMedium.instance.GameStart ();
		ScoreManagerMedium.instance.StartScore ();
		GameObject.Find ("PlatformSpawner").GetComponent<PlatformSpawnerMedium> ().StartSpawningPlatforms();
	}

	public void GameOver()
	{
		
		ScoreManagerMedium.instance.StopScore ();
		UiManagerMedium.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
		gameOver = true;
	}
}
