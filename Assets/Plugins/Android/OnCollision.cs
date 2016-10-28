using UnityEngine;
using System.Collections;
using System;

public class OnCollision : MonoBehaviour {

	public Action onDestoyed;

	void OnTriggerEnter( Collider collision ) {
		//print ("enter called");
		//print (gameObject.name);

		Handheld.Vibrate ();
		if (onDestoyed != null)
			onDestoyed ();
		
		//Destroy (this.gameObject);

	
	}



}
