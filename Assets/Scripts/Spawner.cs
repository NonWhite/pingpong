using UnityEngine;
using System.Collections;
using Utils ;

public class Spawner : MonoBehaviour {
	
	public GameObject ball ;

	private Vector3 position ;

	void Start () {
		Spawn ();
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Spawn() ;
		}
	}

	void CreateRandomPosition(){
		int randX = Random.Range (Constants.MIN_XPOS, Constants.MAX_XPOS);
		int randY = Random.Range (Constants.MIN_YPOS, Constants.MAX_YPOS);
		position = new Vector3 (randX, randY, 0);
	}

	void Spawn(){
		CreateRandomPosition ();
		Instantiate (ball, position, Quaternion.identity);
	}
}
