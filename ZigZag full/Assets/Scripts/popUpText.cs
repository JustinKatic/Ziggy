using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUpText : MonoBehaviour {

	public Text ScorePopUp;

	void Start ()
	{
		ScorePopUp.gameObject.SetActive (false);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Diamond") {
			ScorePopUp.gameObject.SetActive (true);
			Invoke ("ActiveFalse", 0.8F);

		}
	}
		void ActiveFalse()
		{
			ScorePopUp.gameObject.SetActive (false);
		}
	}




		
