using UnityEngine;
using System.Collections;

public class ButtonEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.Rotate(new Vector3(0f, 0f, 5f));
        iTween.RotateTo(gameObject, iTween.Hash("z", -5f, "loopType", iTween.LoopType.pingPong, "speed", 45f, "easeType",
iTween.EaseType.linear));
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    
}
