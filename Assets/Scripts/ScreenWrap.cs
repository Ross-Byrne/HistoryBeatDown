using UnityEngine;
using System.Collections;

public class ScreenWrap : MonoBehaviour
{
	public GameObject GaObject;


	public float topScreen = 0.0f;
	public float bottomScreen = 0.0f;
	public float leftScreen = 0.0f;
	public float rightScreen = 0.0f;

	public float buffer = 1.0f;
	public float distanceZ = 10.0f;


	// Use this for initialization
	void Awake ()
	{
		leftScreen = Camera.main.ScreenToWorldPoint (new Vector3 (0.0f, 0.0f, distanceZ)).x;
		rightScreen = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, 0.0f, distanceZ)).x;

	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 GaObjectPos = GaObject.transform.position;


		if (GaObjectPos.x < leftScreen)
		{
			// GameObject is past world-space view / off screen
			GaObject.transform.position = new Vector3 (rightScreen - buffer, 0f, 0f);  // move ship to opposite side
		}

		if (GaObjectPos.x > rightScreen)
		{
			// GameObject is past world-space view / off screen
			GaObject.transform.position = new Vector3 (leftScreen + buffer, 0f, 0f);
		}
	}
}