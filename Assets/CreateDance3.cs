using UnityEngine;
using System.Collections;

public class CreateDance3 : MonoBehaviour {

	public GameObject[] bubbles = new GameObject[ 16 ];
	public float dance_height;
	public float wiggle_radius;
	public float wiggle_amplitude;
	public float wiggle_frequency;
	public float wiggle_spacing;

	public Material wiggle2_material;




	// Use this for initialization
	void Start () {
			
		//wiggle 2
		for (int i = 0; i < bubbles.Length ; i++) {
			GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			sphere.transform.position = new Vector3 (  -1 * wiggle_amplitude * Mathf.Sin( wiggle_frequency * i ), dance_height, wiggle_spacing * i);
			sphere.transform.localScale = new Vector3 ( wiggle_radius, wiggle_radius, wiggle_radius );
			sphere.AddComponent<OnCollision> ();
			sphere.GetComponent<SphereCollider> ().isTrigger = true;
			sphere.GetComponent<MeshRenderer>().sharedMaterial = wiggle2_material;
		}
			

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
