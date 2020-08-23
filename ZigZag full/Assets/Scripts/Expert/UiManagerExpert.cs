using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManagerExpert : MonoBehaviour {

	public static UiManagerExpert instance;

	public GameObject zigzagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highScore1;
	public Text highScore2;

	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}


	// Use this for initialization
	void Start () 
	{
		highScore1.text = "High Score Expert:" + PlayerPrefs.GetInt("highScoreExpert");
	}
	public void GameStart()
	{
		tapText.SetActive (false);
		zigzagPanel.GetComponent<Animator> ().Play ("PanelUp");

	}
	public void GameOver()
	{
		score.text = PlayerPrefs.GetInt ("scoreExpert").ToString();
		highScore2.text = PlayerPrefs.GetInt ("highScoreExpert").ToString();
		gameOverPanel.SetActive (true);
	}
	public void Reset()
	{
		SceneManager.LoadScene (4);
	}
	public void MenuScreen()
	{
		SceneManager.LoadScene (0);
	}
	// Update is called once per frame
	void Update () 
	{
		
	}
}
