using UnityEngine;
using System.Collections;

public class ScaleBtnEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.ScaleTo(gameObject, iTween.Hash("x", gameObject.transform.localScale.x + 0.03f, "y", gameObject.transform.localScale.y + 0.03f , "time", 0.5f, "easetype", iTween.EaseType.easeOutElastic, "loopType", iTween.LoopType.pingPong));
	}
	
}
