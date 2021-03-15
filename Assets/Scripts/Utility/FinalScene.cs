using UnityEngine;
using System.Collections;

public class FinalScene : MonoBehaviour {

	// Use this for initialization
	void Start () {



	}


	public void AddMask(float x, float y)
	{
		if(GameManager.Instance.b_isRateCall == true){
		Debug.Log ("Rect Start");
		if (x < 2f && x > -2f && y < 2f && y > -2f )
		{
//			GameObject.Find("eatingsound").GetComponent<AudioSource>().Play();
			GameObject.Instantiate(GameObject.Find("DepthMask"), new Vector3(x, y, 0), Quaternion.identity);
		Debug.Log ("In To The Rect Start");
			
		}
		Debug.Log ("Rect End");
		}
	}
}
