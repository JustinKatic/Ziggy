using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerEasy : MonoBehaviour {

	public GameObject particle;


	public float speed;
	bool started;
	bool gameOver;
	public AudioClip EatFishClip;
	AudioSource audioSource;

	Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Start ()
	{
		started = false;
		gameOver = false;
		audioSource = GetComponent <AudioSource> ();
	}

	void Update ()
	{
		if (!started) 
		{
			if (Input.GetMouseButtonDown (0))
			{
				rb.velocity = new Vector3 (speed, 0, 0);
				started = true;

				GameManagerEasy.instance.StartGame ();
			}
		}
		if (!Physics.Raycast (transform.position, Vector3.down, 1f) && !gameOver)
		{
			gameOver = true;
			rb.velocity = new Vector3 (0, -25f, 0);

			Camera.main.GetComponent<CameraFollow> ().gameOver = true;

			GameManagerEasy.instance.GameOver ();
		}

		if (Input.GetMouseButtonDown (0)&& !gameOver) 
		{
			SwitchDirection ();
		}
	}

	void SwitchDirection()
	{
		if (rb.velocity.z > 0) {
			rb.velocity = new Vector3 (speed, 0, 0);
			transform.rotation = Quaternion.Euler (0, 180, 0);
		}
		else if (rb.velocity.x > 0)
		{
			rb.velocity = new Vector3 (0, 0, speed);
			transform.rotation = Quaternion.Euler (0, 90, 0);

		}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Diamond")
		{
			audioSource.PlayOneShot (EatFishClip);
			ScoreManagerEasy.instance.score += 2;
			GameObject particles = Instantiate (particle, col.gameObject.transform.position, Quaternion.identity) as GameObject;
			Destroy (col.gameObject);
			Destroy (particles, 1f);
		}
	}
}
