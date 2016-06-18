using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

	public Text clockCountDown;

	private float time1 = 90.0f;

	
	// Update is called once per frame
	void Update ()
	{
		time1 -= Time.deltaTime;
		clockCountDown.text = Mathf.Round (time1).ToString();

		if(time1 < 0)
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}
