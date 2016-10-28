using UnityEngine;
using System.Collections;

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

	//public Material wiggle1_material;
	//public Material turn1_material;
	//public Material wiggle2_material;
	public Material turn2_material;




	// Use this for initialization
	void Start () {
		//turn 1
		for (int i = 0; i < bubbles.Length; i++) {

			bubbles[ i ] = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bubbles[ i ].transform.position = new Vector3 ( -1 * turn_amplitude * Mathf.Sin( turn_frequency * i ), dance_height, turn_spacing * ( i ));
			bubbles[ i ].transform.localScale = new Vector3 ( turn_radius, turn_radius, turn_radius );
			bubbles[ i ].AddComponent<OnCollision> ();
			bubbles[ i ].GetComponent<SphereCollider> ().isTrigger = true;
			bubbles[ i ].GetComponent<MeshRenderer>().sharedMaterial = turn2_material;
		}
	}

	// Update is called once per frame
	void Update () {

		/*for (int i = 0; i < bubbles.Length; i++) {

			bubbles [i].transform.position = new Vector3 (turn_amplitude * Mathf.Sin (turn_frequency * i ), dance_height, turn_spacing * i);
			bubbles [i].transform.localScale = new Vector3 (turn_radius, turn_radius, turn_radius);
		}*/

	}
}
