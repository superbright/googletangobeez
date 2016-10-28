﻿using UnityEngine;
using System.Collections;

public class Careography : MonoBehaviour {

	public CreateDance part1;
	public CreateDance2 part2;
	public CreateDance3 part3;
	public CreateDance4 part4;

	int currentPart = 0;

	// Use this for initialization
	void Start () {
		NextPart ();
	}

	void Reset() {
		currentPart = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Change the current part to dance and call the function setting it p
	/// </summary>
	void NextPart() {

		Debug.Log ("NEXT");
		currentPart++;
		switch (currentPart) {
		case 1:
			{
				StartPart1 ();
				break;
			}
		case 2:
			{
				StartPart2 ();
				break;
			}

		case 3:
			{
				StartPart3 ();
				break;
			}
		case 4:
			{
				StartPart4 ();
				break;
			}
		}
	}

	/// <summary>
	/// Starts the part1 and setup callback when it is over
	/// </summary>
	public void StartPart1() {
		
		part1.DrawDance ();
		part1.BeginDance( 
			() => { 
				NextPart();
			});
	}

	public void StartPart2() {
		part2.DrawDance ();
		part2.BeginDance( 
			() => { 
				NextPart();
			});
	}

	public void StartPart3() {
		part3.DrawDance ();
		part3.BeginDance( 
			() => { 
				NextPart();
			});
	}

	public void StartPart4() {
		part4.DrawDance ();
		part4.BeginDance( 
			() => { 
				NextPart();
			});
	}
}