using UnityEngine;
using System.Collections;

// Class for generating the level

public class LevelGeneration : MonoBehaviour {

	public float screenWidth;
	public float screenHeight;
	public float tileSize;
	public int screenWidthInTiles;
	public int screenHeightInTiles;

	void Awake(){

		screenHeightInTiles = 20;
		screenWidthInTiles = 40;

		// the the screen width and height
		screenWidth = Screen.width;
		screenHeight = Screen.height;




	} // Awake()

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
