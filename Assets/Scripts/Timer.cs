using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text clockCountDown;

	private float time = 90.0f;

	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;

		float mins = time / 60;
		float secs = time % 60;

		clockCountDown.text = string.Format ("{0:00} : {1:00}", mins, secs);
	}
}
