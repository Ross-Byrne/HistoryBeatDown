using UnityEngine;
using System.Collections;

// Class for generating the level

public class LevelGeneration : MonoBehaviour {

	public float screenWidth;
	public float screenHeight;
	public float tileSize;
	public int screenWidthInTiles;
	public int screenHeightInTiles;
	public float moveFactor;
	public float currentPos;

	public GameObject tile;

	void Awake(){



		tileSize = 1;


		// the the screen width and height
		screenWidth = Screen.width;
		screenHeight = Screen.height;

		//tileSize = 64;

		screenHeightInTiles = 5;
		screenWidthInTiles = 20;
	

		currentPos = screenWidthInTiles / 2;
	} // Awake()

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
