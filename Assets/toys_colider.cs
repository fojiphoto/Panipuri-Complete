using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class toys_colider : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("collision"+ col.gameObject.tag);

		if (col.gameObject.tag == "toy") {
			Instantiate (GameObject.FindObjectOfType<minigame> ().coin, GameObject.Find ("E").transform.position, Quaternion.identity);
			Destroy( col.gameObject.GetComponent<BoxCollider2D> ());
			Destroy(col.gameObject.GetComponent<Rigidbody> ());

			col.gameObject.transform.DOMove (GameObject.Find ("E").transform.position, .5f, false);
			col.gameObject.transform.parent = GameObject.Find ("E").transform;
			GameObject.Find ("pt").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("item").GetComponent<AudioSource> ().Play ();
			col.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			Destroy (col.gameObject); 
		}
		if (col.gameObject.tag == "ghose") {
			
		
			GameObject.FindObjectOfType<minigame> ().StopAllCoroutines ();
			GameObject.Find ("wrong").GetComponent<AudioSource> ().Play ();
			Destroy( col.gameObject.GetComponent<BoxCollider2D> ());
			Destroy(col.gameObject.GetComponent<Rigidbody> ());
			GameObject.FindObjectOfType<minigame> ().Replay.SetActive (true);
			GameObject.FindObjectOfType<minigame> ().t = false;
			GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
			GameObject.Find ("basket").GetComponent<BoxCollider2D>().enabled=false;
			col.gameObject.transform.DOMove (GameObject.Find ("E").transform.position, .5f, false);
			col.gameObject.transform.parent = GameObject.Find ("basket").transform;
			//StartCoroutine (des( col));
			col.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			Destroy (col.gameObject); 
		}

	}
	IEnumerator des(Collision col)
	{
		yield return new WaitForSeconds (.6f);
		Destroy (col.gameObject); 
	}


}
