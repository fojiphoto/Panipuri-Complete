using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Blinking_effect : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine (Blink());
		
	}


	IEnumerator Blink()
	{
		yield return new WaitForSeconds (.5f);
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (.7f);
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		StartCoroutine (Blink());
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
