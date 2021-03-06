﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterStatus : MonoBehaviour {

	public int TotalLifePoints = 100;
	public int LivePoints = 100;
	public int DamagePerHit = 10;

	public AudioClip hitSFX;

	AudioSource _audio;

	// Use this for initialization
	void Start () {
		_audio = GetComponent<AudioSource> ();
		LivePoints = TotalLifePoints;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.tag == "Projectile") 
		{
			Destroy (coll.gameObject);
			HandleHit ();
		}

	}

	void HandleHit ()
	{
		//todo
		//Debug.Log("Hit " + this.gameObject.tag);
		LivePoints -= DamagePerHit;
		_audio.PlayOneShot (hitSFX);

		if (gameObject.tag == "Player 1")
		{
			GameObject.FindGameObjectWithTag ("pHealth1").GetComponent<Image>().fillAmount = 
				(float)LivePoints/TotalLifePoints;

		}
		else
		{
			GameObject.FindGameObjectWithTag ("pHealth2").GetComponent<Image>().fillAmount = 
				(float)LivePoints/TotalLifePoints;
		}
		if (LivePoints <= 0)
			HandleDeath ();
	}

	void HandleDeath() {
		Debug.Log("Died " + this.gameObject.tag);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
