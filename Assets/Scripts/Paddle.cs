using UnityEngine;
using System.Collections;
using Utils ;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1 ;
	public Vector3 playerPos ;

	private float minYpos = Constants.MIN_YPOS ;
	private float maxYpos = Constants.MAX_YPOS ;
	private float playerXpos = Constants.PLAYER_XPOS ;

	void Update () {
		float yPos = gameObject.transform.position.y + (paddleSpeed * Input.GetAxis("Vertical"));
		yPos = Mathf.Clamp (yPos, minYpos, maxYpos);
		playerPos = new Vector3 ( playerXpos, yPos , 0);
		gameObject.transform.position = playerPos;
	}
}