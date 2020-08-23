using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerMedium : MonoBehaviour {

	public static ScoreManagerMedium instance;
	public int score;
	public int highScore;
	public Text scoreText;
	public int currentScore;
	public Text CurrentScoreText;

	// Use this for initialization
	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}

	void Start ()
	{
		score = 0;
		PlayerPrefs.SetInt ("scoreMedium", score);
		currentScore = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		CurrentScoreText.text = currentScore.ToString ();
	}
	void incrementScore()
	{
		score += 1;
		currentScore = score;
	}
	public void StartScore()
	{
		InvokeRepeating ("incrementScore", 0.1f, 0.5f);
	}
	public void StopScore()
	{
		CancelInvoke ("incrementScore");
		PlayerPrefs.SetInt ("scoreMedium", score);

		if (PlayerPrefs.HasKey ("highScoreMedium"))
		{
			if (score > PlayerPrefs.GetInt ("highScoreMedium"))
			{
				PlayerPrefs.SetInt ("highScoreMedium", score);
			}
		} 
		else 
		{
			PlayerPrefs.SetInt ("highScoreMedium", score);
		}

	}
}
