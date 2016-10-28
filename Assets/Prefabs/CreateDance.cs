using UnityEngine;
using System.Collections;

public class CreateDance : MonoBehaviour {

	//public int number_of_spheres;

	public GameObject[] bubbles = new GameObject[ 16 ];
	public float dance_height;
	public float wiggle_radius;
	public float wiggle_amplitude;
	public float wiggle_frequency;
	public float wiggle_spacing;

	/*public float turn_radius;
	public float turn_amplitude;
	public float turn_frequency;
	public float turn_spacing;*/

	public Material wiggle1_material;
	//public Material turn1_material;
	//public Material wiggle2_material;
	//public Material turn2_material;





	// Use this for initialization
	void Start () {
		//wiggle 1
		for (int i = 0; i < bubbles.Length; i++) {

			bubbles[ i ] = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bubbles[ i ].transform.position = new Vector3 ( wiggle_amplitude * Mathf.Sin( wiggle_frequency * i ), dance_height, wiggle_spacing * i);
			bubbles[ i ].transform.localScale = new Vector3 ( wiggle_radius, wiggle_radius, wiggle_radius );
			bubbles[ i ].AddComponent<OnCollision> ();
			bubbles[ i ].GetComponent<SphereCollider> ().isTrigger = true;
			bubbles[ i ].GetComponent<MeshRenderer>().sharedMaterial = wiggle1_material;

		}
		//turn 1
		/*for (int i = bubbles.Length / 2; i < bubbles.Length; i++) {

			bubbles[ i ] = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bubbles[ i ].transform.position = new Vector3 ( turn_amplitude * Mathf.Sin( turn_frequency * i ), dance_height, turn_spacing * ( i - bubbles.Length / 2 ));
			bubbles[ i ].transform.localScale = new Vector3 ( turn_radius, turn_radius, turn_radius );
			bubbles[ i ].AddComponent<OnCollision> ();
			bubbles[ i ].GetComponent<SphereCollider> ().isTrigger = true;
			bubbles[ i ].GetComponent<MeshRenderer>().sharedMaterial = turn1_material;
	
		}
			
		//wiggle 2
		/*(for (int i = 0; i < (int)( number_of_spheres / 2 ); i++) {
			GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			sphere.transform.position = new Vector3 (  -1 * wiggle_amplitude * Mathf.Sin( wiggle_frequency * i ), dance_height, wiggle_spacing * i);
			sphere.transform.localScale = new Vector3 ( wiggle_radius, wiggle_radius, wiggle_radius );
			sphere.AddComponent<OnCollision> ();
			sphere.GetComponent<SphereCollider> ().isTrigger = true;
			sphere.GetComponent<MeshRenderer>().sharedMaterial = wiggle2_material;
		}

		//turn 2
		for (int i = 0; i < (int)( number_of_spheres / 2 ); i++) {
			GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			sphere.transform.position = new Vector3 ( -1 * turn_amplitude * Mathf.Sin( turn_frequency * i ), dance_height, turn_spacing * i);
			sphere.transform.localScale = new Vector3 ( turn_radius, turn_radius, turn_radius );
			sphere.AddComponent<OnCollision> ();
			sphere.GetComponent<SphereCollider> ().isTrigger = true;
			sphere.GetComponent<MeshRenderer>().sharedMaterial = turn2_material;
		}*/


	}

	
	// Update is called once per frame
	void Update () {

		/*for (int i = 0; i < bubbles.Length / 2; i++) {

			bubbles[ i ].transform.position = new Vector3 ( wiggle_amplitude * Mathf.Sin( wiggle_frequency * i ), dance_height, wiggle_spacing * i);
			bubbles[ i ].transform.localScale = new Vector3 ( wiggle_radius, wiggle_radius, wiggle_radius );
	
		}

		for (int i = bubbles.Length / 2; i < bubbles.Length; i++) {

			bubbles [i].transform.position = new Vector3 (turn_amplitude * Mathf.Sin (turn_frequency * i), dance_height, turn_spacing * (i - bubbles.Length / 2));
			bubbles [i].transform.localScale = new Vector3 (turn_radius, turn_radius, turn_radius);
		}*/
	
	}
}
