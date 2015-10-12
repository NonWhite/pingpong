using UnityEngine;
using System.Collections;
using Utils ;

public class Ball : MonoBehaviour {

	public float ballVelocity = Constants.BALL_VELOCITY ;

	private Rigidbody rb ;
	private bool isPlay ;
	private int randInt ;

	void Awake(){
		rb = gameObject.GetComponent<Rigidbody> ();
		randInt = Random.Range (1, 2);
	}

	void Update(){
		if( Input.GetMouseButton( 0 ) == true && !isPlay ){
			transform.parent = null ;
			isPlay = true ;
			rb.isKinematic = false ;
			if( randInt == 1 ){
				rb.AddForce( new Vector3( ballVelocity , ballVelocity , 0 ) ) ;
			}
			if( randInt == 2 ){
				rb.AddForce( new Vector3( -ballVelocity , -ballVelocity , 0 ) ) ;
			}
		}

	}
}
