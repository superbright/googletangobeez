using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {


	public UnityEngine.UI.Text scoreText;
	public UnityEngine.UI.Scrollbar scroll;
	int score = 0;
	float scrollsize = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncreamentProgressBar() {
		scrollsize += 0.4f;
		scroll.size = scrollsize;
	}

	public void ResetProgressBar() {

		if (scrollsize > 0) {
			scroll.size = 0;
			scrollsize = 0;
			IncScore ();
		}
	}

	public void IncScore() {

		score++;
		scoreText.text = score.ToString();
	}


}
