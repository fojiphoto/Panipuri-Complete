using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using DG.Tweening;

[RequireComponent(typeof(BoxCollider))]

public class Eatrita : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public event Action ActionDownEvent;
    public event Action ActionMoveEvent;
    public event Action ActionUpEvent;


	int i = 0; 
    FinalScene fsScript = new FinalScene();

    //On action down of the sprite/gameobject .
    void OnMouseDown()
    {

	
        offset = 
                Camera.main.ScreenToWorldPoint(
                    new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        fsScript.AddMask(offset.x,offset.y);
		if (offset.x < 4f && offset.x > -4f && offset.y < 4f && offset.y > -4f) {
			i++;

			Debug.Log ("eating ");

			GameObject.Find ("Delicious").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("eat").GetComponent<AudioSource> ().Play ();
			GameObject myob = Instantiate (GameObject.Find ("DPM"), new Vector3 (offset.x, offset.y, 0f), Quaternion.identity) as GameObject;
			myob.transform.parent = GameObject.Find ("emp1").transform;
			//GameObject.Find ("eat_partical").transform.position = new Vector3 (offset.x, offset.y, 0f);
			if (i >= 12) {
				DOTween.Play ("1");
			}
		}




		Cursor.visible = true;
        if (ActionDownEvent != null)
            ActionDownEvent();

    }

}
