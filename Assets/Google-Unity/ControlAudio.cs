using UnityEngine;
using System.Collections;

public class ControlAudio : MonoBehaviour {

	public AudioSource sound1;
	public AudioSource sound2;
	public Transform you;
	public Transform sound1_center;
	public Transform sound2_center;
	public float distance_to_sound1;
	public float distance_to_sound2;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Calculate_distance();
		//sound1.
	}

	void Calculate_distance(){
		if (you != null) {
			distance_to_sound1 = Vector3.Distance(you.position, sound1_center.position);
			print("Distance to sound1: " + distance_to_sound1);

			distance_to_sound2 = Vector3.Distance(you.position, sound2_center.position);
			print("Distance to sound2: " + distance_to_sound2);
		}
	}
}
