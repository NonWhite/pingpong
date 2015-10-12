using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public TextMesh curScore ;
	public GameObject ballPref ;
	public Transform paddleObj ;

	private GameObject ball ;
	private int score ;

	void Update () {
		ball = GameObject.FindGameObjectWithTag ("Ball");
		curScore.text = "" + score;
	}

	void OnTriggerEnter( Collider other ){
		if (other.tag == "Ball") {
			score += 1 ;
			Destroy ( ball ) ;
			Vector3 ballPos = new Vector3( paddleObj.transform.position.x + 2 , paddleObj.transform.position.y , 0 ) ;
			GameObject newBall = Instantiate( ballPref , ballPos , Quaternion.identity ) as GameObject ;
			newBall.transform.parent = paddleObj ;
		}
	}
}
