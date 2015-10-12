using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour {

	public int ballVelocity = 500 ;
	public Rigidbody rb ;

	void Awake(){
		rb.velocity = new Vector3 (ballVelocity, ballVelocity, 0);
	}
}
