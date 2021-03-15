using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class coinmove : MonoBehaviour {
	
	public static int j;
	// Use this for initialization
	void Start () {
		gameObject.transform.DORotate (new Vector3 (0f, -180f, 0f), .3f, RotateMode.Fast).SetLoops (-1,LoopType.Incremental);
		gameObject.transform.DOLocalMove (GameObject.Find ("coin").transform.position, 1f, false).OnComplete(cm);
	}
	void cm()
	{
		j++;
		//j = j + 1;
		GameObject.Find ("text").GetComponent<tk2dTextMesh> ().text = j.ToString();
		PlayerPrefs.SetInt ("coin",j);
		Destroy (gameObject,.2f);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
