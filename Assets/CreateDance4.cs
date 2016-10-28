using UnityEngine;
using System.Collections;
using System;

public class CreateDance4 : MonoBehaviour {

	public GameObject[] bubbles = new GameObject[ 16 ];
	public float dance_height;
	/*public float wiggle_radius;
	public float wiggle_amplitude;
	public float wiggle_frequency;
	public float wiggle_spacing;*/

	public float turn_radius;
	public float turn_amplitude;
	public float turn_frequency;
	public float turn_spacing;

	public Material turn2_material;


	Action onComplete;
	Action playSound;
	int currentStep = 15;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	/// <summary>
	/// Begins the dance and setup oncomplete callback
	/// </summary>
	/// <param name="completeCallback">Complete callback.</param>
	public void BeginDance(Action completeCallback,Action soundPlayer) {

		onComplete = completeCallback;
		playSound = soundPlayer;
	}

	public void DrawDance(Transform parent) {
		//turn 1
		for (int i = 0; i < bubbles.Length; i++) {

			bubbles[ i ] = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bubbles [i].transform.parent = parent;
			bubbles[ i ].transform.localPosition = new Vector3 ( -1 * turn_amplitude * Mathf.Sin( turn_frequency * i ), dance_height, turn_spacing * ( i ));
			bubbles[ i ].transform.localScale = new Vector3 ( turn_radius, turn_radius, turn_radius );
			bubbles[ i ].AddComponent<OnCollision> ();
			bubbles[ i ].GetComponent<SphereCollider> ().isTrigger = true;
			bubbles[ i ].GetComponent<MeshRenderer>().sharedMaterial = turn2_material;
			bubbles[i].GetComponent<OnCollision>().onDestoyed = () => {
				NextStep();
			};
		}
	}


	/// <summary>
	/// Nexts the step in the dance
	/// </summary>
	public void NextStep() {

		playSound ();
		Destroy (bubbles [currentStep]);
		currentStep--;

	
		// completed part
		if (currentStep == 0) {

			if (onComplete != null)
				onComplete ();
		}
	}
}
