using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerExpert : MonoBehaviour {

	public static ScoreManagerExpert instance;
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
		PlayerPrefs.SetInt ("scoreExpert", score);
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
		PlayerPrefs.SetInt ("scoreExpert", score);

		if (PlayerPrefs.HasKey ("highScoreExpert"))
		{
			if (score > PlayerPrefs.GetInt ("highScoreExpert"))
			{
				PlayerPrefs.SetInt ("highScoreExpert", score);
			}
		} 
		else 
		{
			PlayerPrefs.SetInt ("highScoreExpert", score);
		}

	}
}
