﻿using UnityEngine;
using System.Collections;

public class HoneySuckle : MonoBehaviour {

	public AudioSource pollen_music;
	float timeLeft = 5.0f;
	bool isSucking = false;
	public GameLogic logic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isSucking) {
			timeLeft -= Time.deltaTime;
			if(timeLeft < 0)
			{
				logic.IncreamentProgressBar ();
				timeLeft = 5.0f;
			}
			if (pollen_music != null)
				//music.Play ();
				pollen_music.volume = 0.5f;
		}
	}

	void OnTriggerEnter(Collider collider) {
		//ContactPoint contact = collider.contacts[0];
		if (collider.gameObject.name == "hive") {
			logic.ResetProgressBar ();
		} else if(collider.gameObject.name == "flower") {
			isSucking = true;
			collider.gameObject.GetComponent<ParticleSystem> ().Play ();
		}

	}

	void OnTriggerExit(Collider collider) {
		//ContactPoint contact = collider.contacts[0];
		if (collider.gameObject.name == "hive") {

		} else if(collider.gameObject.name == "flower") {
			isSucking = false;
			collider.gameObject.GetComponent<ParticleSystem> ().Stop ();
			if (pollen_music != null)
				//music.Play ();
				pollen_music.volume = 0.0f;
		}

	}
}
