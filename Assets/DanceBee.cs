using UnityEngine;
using System.Collections;

public class DanceBee : MonoBehaviour {

	public Transform[] waypointArray;
	float percentsPerSecond = 0.1f; // %2 of the path moved per second
	float currentPathPercent = 0.0f; //min 0, max 1
	public GameObject bee;
	public GameObject beeRotationParent;

	static Vector3[] smallCircle = new Vector3[]{ new Vector3(0f,0f,-1f), new Vector3(1f,0f,-0f), new Vector3(1f,0f,-1f), new Vector3(1f,0f,0f), new Vector3(1f,0f,0f), new Vector3(0.5f,0f,1f), new Vector3(1.0f,0f,0.6f), new Vector3(0f,0f,1f) };
	Vector3[] bigCircle = new Vector3[]{ new Vector3(0f,0f,-5f), new Vector3(4.88f,0f,-3.61f), new Vector3(2.29f,0f,-4.9f), new Vector3(4.66f,0f,0f), new Vector3(4.66f,0f,0f), new Vector3(1.18f,0f,5.36f), new Vector3(5f,0f,4.355f), new Vector3(0f,0f,5f) };
	//LTSpline spline = new LTSpline(new Vector3[]{ new Vector3(0f,0f,0f), new Vector3(5f,0f,0f), new Vector3(3.15f,0f,0f), new Vector3(5f,-0.06f,4.7f) });
	LTBezierPath bezier = new LTBezierPath(smallCircle);
	LTBezierPath finalrunBezier = new LTBezierPath(
		new Vector3[]{ new Vector3(0f,0f,1.048741f), new Vector3(0f,0f,-0.05125844f), new Vector3(0f,0f,-0.05125844f), new Vector3(0f,0f,-1.0f) });

	// Use this for initialization
	void Start () {
		//spline = new LTSpline( new Vector3[] {waypointArray[0].position, waypointArray[1].position} );
		//LeanTween.moveSpline( bee, spline.pts, 3f).setEase(LeanTweenType.easeInOutQuad).setOrientToPath(true);
		//LeanTween.move (bee, spline, 7f).setOrientToPath(true);
		kickCircle();
	}

	void kickCircle() {
		LeanTween.moveLocal (bee, bezier, 3.0f).setOrientToPath(true).setOnComplete( 
			()=> {
				finalMove();
			});
	}
	
	void finalMove() {
		LeanTween.moveLocal (bee, finalrunBezier, 4.0f).setOrientToPath(true);
		LeanTween.rotateY (beeRotationParent, 150, 0.5f).setOnComplete (
			() => {
				LeanTween.rotateY (beeRotationParent, 210, 0.25f).setLoopPingPong(8).setOnComplete(
					() => {
						beeRotationParent.transform.Rotate(new Vector3(0,180,0));
						kickCircle();
					});
			});
	}

	void OnDrawGizmos()
	{
		if(bezier!=null) 
			bezier.gizmoDraw(); // debug aid to be able to see the path in the scene inspector
	}
}
