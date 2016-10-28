using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour {

	void OnTriggerEnter( Collider collision ) {
		print ("enter called");
		print (gameObject.name);
		Destroy (this.gameObject);
		Handheld.Vibrate ();
	
	}



}
