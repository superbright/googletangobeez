using UnityEngine;
using System.Collections;
using System;

public class CreateDance3 : MonoBehaviour {

	public GameObject[] bubbles = new GameObject[ 16 ];
	public float dance_height;
	public float wiggle_radius;
	public float wiggle_amplitude;
	public float wiggle_frequency;
	public float wiggle_spacing;

	public Material wiggle2_material;


	Action onComplete;
	Action playSound;
	int currentStep = 0;

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

	public void DrawDance() {

		//wiggle 2
		for (int i = 0; i < bubbles.Length ; i++) {
			bubbles[ i ] = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bubbles[ i ].transform.position = new Vector3 (  -1 * wiggle_amplitude * Mathf.Sin( wiggle_frequency * i ), dance_height, wiggle_spacing * i);
			bubbles[ i ].transform.localScale = new Vector3 ( wiggle_radius, wiggle_radius, wiggle_radius );
			bubbles[ i ].AddComponent<OnCollision> ();
			bubbles[ i ].GetComponent<SphereCollider> ().isTrigger = true;
			bubbles[ i ].GetComponent<MeshRenderer>().sharedMaterial = wiggle2_material;
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
		currentStep++;

		//Debug.Log ("step " + currentStep);
		// completed part
		if (currentStep == bubbles.Length) {

			if (onComplete != null)
				onComplete ();
		}
	}
}
