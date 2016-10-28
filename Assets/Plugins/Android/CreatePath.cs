using UnityEngine;
using System.Collections;

public class CreatePath : MonoBehaviour {

	public GameObject[] MySpheres;

	// Use this for initialization
	void Start () {
		Instantiate( MySpheres[ 4 ]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
