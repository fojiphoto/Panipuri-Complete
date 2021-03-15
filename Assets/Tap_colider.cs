using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
public class Tap_colider : MonoBehaviour {


	private Vector3 screenPoint;
	private Vector3 offset;
	public  event Action ActionDownEvent ;
	public  event Action ActionMoveEvent ;
	public  event Action ActionUpEvent ;
	public bool i, j, k, l=false;
	public static int n;
	void OnMouseDown() {
		offset = gameObject.transform.position -
		Camera.main.ScreenToWorldPoint (
			new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		n++;
		if (gameObject.transform.name == "p1") {
			i = true;
			n++;
			GameObject.Find ("p1").GetComponent<SpriteRenderer> ().enabled = true;
			GameObject.Find ("p1").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("eg").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("p1").transform.position;
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
		}
		if (gameObject.transform.name == "p2") {
			j = true;
			n++;
			GameObject.Find ("p2").GetComponent<SpriteRenderer> ().enabled = true;
			GameObject.Find ("p2").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("p2").transform.position;
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("eg").GetComponent<AudioSource> ().Play ();
		}
		if (gameObject.transform.name == "p3") {

			k = true;
			n++;
			GameObject.Find ("p3").GetComponent<SpriteRenderer> ().enabled = true;
			GameObject.Find ("p3").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("p3").transform.position;
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("eg").GetComponent<AudioSource> ().Play ();
		}
		if (gameObject.transform.name == "p4") {
			l = true;
			n++;
			GameObject.Find ("p4").GetComponent<SpriteRenderer> ().enabled = true;
			GameObject.Find ("p4").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("p4").transform.position;
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("eg").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = true;
			DOTween.Play ("26");

		}
		Debug.Log (n);
		if(ActionDownEvent != null)
			ActionDownEvent();
	}

	void OnMouseUp(){
		Cursor.visible = true;
		if(ActionUpEvent != null)
			ActionUpEvent();
	}


}
