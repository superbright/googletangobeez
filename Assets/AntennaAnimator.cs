using UnityEngine;
using System.Collections;

public class AntennaAnimator : MonoBehaviour {

	public GameObject left;
	public GameObject right;
	public Rigidbody rb;
	bool isAnimating = false;
	public AudioSource music;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!isAnimating && !rb.IsSleeping ()) {
			isAnimating = true;
			if (music != null)
				music.Play ();
			AnimateEars ();
		}

		if(isAnimating && rb.IsSleeping()) {
			isAnimating = false;
			if (music != null)
				music.Pause ();
			StopAnimating();
		}
	
	}

	public void AnimateEars() {

		
		LeanTween.rotateZ (left, 110, 0.5f).setLoopPingPong ();
		LeanTween.rotateZ (right, 110, 0.5f).setLoopPingPong ().setDelay (0.2f);
	}

	public void StopAnimating() {
		LeanTween.cancel (left);
		LeanTween.cancel (right);
		LeanTween.rotateZ (left, 90, 0.5f);
		LeanTween.rotateZ (right, 90, 0.5f);

	}
}
