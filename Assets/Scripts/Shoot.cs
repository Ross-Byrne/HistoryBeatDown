using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject projectile;

	public float fireDelay = 0.25f;
	public float cooldownTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		cooldownTimer = fireDelay;

		if (Input.GetMouseButtonDown (0) && cooldownTimer <= 0) {


			// fire projectile
			GameObject newProjectile = Instantiate (projectile, transform.position, transform.rotation) as GameObject;

		}
	
	}
}
