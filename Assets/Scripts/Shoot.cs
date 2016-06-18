using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject projectile;
	public float power = 10.0f;
	public float fireDelay = 0.25f;
	public float cooldownTimer = 0;
	//Rigidbody2D _rigidbody;
		
	// Update is called once per frame
	void Update () 
	{

		cooldownTimer -= Time.deltaTime;

		if (Input.GetButtonDown("Fire1") && cooldownTimer <= 0) 
		{

			cooldownTimer = fireDelay;
			// fire projectile
			GameObject newProjectile = Instantiate (projectile, transform.position, transform.rotation) as GameObject;


		}
	
	}
}
