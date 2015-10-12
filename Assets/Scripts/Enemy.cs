using UnityEngine;
using System.Collections;
using Utils ;

public class Enemy : MonoBehaviour {

	public float speed = Constants.ENEMY_SPEED ;

	private Vector3 targetPos ;
	private GameObject ballObj ;

	private float minYpos = Constants.MIN_YPOS ;
	private float maxYpos = Constants.MAX_YPOS ;
	private float enemyXpos = Constants.ENEMY_XPOS ;

	void Update () {
		ballObj = GameObject.FindGameObjectWithTag ("Ball");
		if (ballObj != null) {
			targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
			float ypos = Mathf.Clamp (targetPos.y, minYpos, maxYpos);
			gameObject.transform.position = new Vector3 (enemyXpos, ypos, 0);
		}
	}
}
