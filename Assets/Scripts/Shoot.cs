using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject projectile;
	public float power = 10.0f;
	public float fireDelay = 0.1f;
	public float cooldownTimer = 0;
	//Rigidbody2D _rigidbody;

	public AudioClip shootSFX;

	AudioSource _audio;



	void Start ()
	{
		_audio = GetComponent<AudioSource> ();

	}
		
		
	// Update is called once per frame
	void Update () 
	{

		cooldownTimer -= Time.deltaTime;

		string fireName = this.transform.parent.parent.tag == "Player 1" ? "Fire_P1" : "Fire_P2";

		if (Input.GetButtonDown(fireName) && cooldownTimer <= 0) 
		{

			cooldownTimer = fireDelay;
			// fire projectile
			GameObject newProjectile = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
			_audio.PlayOneShot (shootSFX);

			newProjectile.GetComponent<MoveFoward> ().playerTransform = this.transform.parent.parent.transform;

		}
	
	}
}
