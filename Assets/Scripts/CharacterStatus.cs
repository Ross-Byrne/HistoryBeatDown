using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour {


	public int LivePoints = 100;
	public int DamagePerHit = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		Debug.Log (coll);
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

		if (LivePoints <= 0)
			HandleDeath ();
	}

	void HandleDeath() {
		Debug.Log("Died " + this.gameObject.tag);
	}
}
