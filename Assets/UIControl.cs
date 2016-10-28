using UnityEngine;
using System.Collections;

public class UIControl : MonoBehaviour {

	public GameObject intropanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void disableIntro() {

		intropanel.SetActive (false);
	}
}
