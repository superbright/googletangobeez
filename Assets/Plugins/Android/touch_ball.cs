using UnityEngine;
using System.Collections;

public class touch_ball : MonoBehaviour {

	public Transform other;
	public float distance_to_ball;
	public bool touched;
	//public float radius;

	void Start() {
		print("script is running");
		distance_to_ball = 0;
		touched = false;
	}
	
	void Update () {
		Calculate_distance ();
		if (distance_to_ball < .3 && touched == false ) {
			print ("we're close");
			Handheld.Vibrate ();
			touched = true;
			Destroy (this.gameObject);
		}
	}

	void Calculate_distance(){
		if (other != null) {
			distance_to_ball = Vector3.Distance(other.position, transform.position);
			//print("Distance to other: " + distance_to_ball);
		}
	}

	void OnCollisionEnter( Collision collision ) {
		print ("enter called");
		//print (collider.gameObject.name);

	}
}
