using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioPlayer : MonoBehaviour {
	[SerializeField] List<AudioClip> audioClips;

//	public static AudioPlayer Instance { 
//
//		get { 
//			if(instance == null){ instance = new AudioPlayer(); }
//			return instance;
//		}
//	
//	}
//	private static AudioPlayer instance = null;

	public string playClipName;

	// Use this for initialization
	public static AudioSource audio;
	
	void Start() {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.M)) {
			PlayClip(playClipName);
		}
	}

	public void PlayClip(string name, float volumeScale = 1f){
		AudioClip _clip = audioClips.Find ((source)=>{ if(source.name ==name ){ return true; } return false; });
		audio.PlayOneShot(_clip, volumeScale);

	}


}
