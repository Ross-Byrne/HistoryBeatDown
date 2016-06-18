using UnityEngine;
using System.Collections;

public class MoveFoward : MonoBehaviour
{
	public Transform playerTransform;
	public float moveSpeed = 7.0f;
	public string direction = "Left";

	void Awake(){

		//playerTransform = GameObject.Find ("Player").GetComponent<Transform> ();

	}

	void Start(){

		if (playerTransform.localScale.x > 0)
		{

			direction = "Right";
		}
		else
		{
			direction = "Left";
		}

	}

	// Update is called once per frame
	void Update ()
	{

		if (direction == "Right")
		{

			Vector3 pos = transform.position;

			Vector3 velocity = new Vector3 (moveSpeed * Time.deltaTime, 0, 0);

			pos += transform.rotation * velocity;

			// update  position
			transform.position = pos;
		}
		else
		{
			Vector3 pos = transform.position;

			Vector3 velocity = new Vector3 (-moveSpeed * Time.deltaTime, 0, 0);

			pos += transform.rotation * velocity;

			// update  position
			transform.position = pos;
		}
	}
}
