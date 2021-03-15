using UnityEngine;
using System.Collections;
using System; 
using DG.Tweening;
[RequireComponent(typeof(BoxCollider2D))]

public class drage_basket : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;
	public  event Action ActionDownEvent ;
	public  event Action ActionMoveEvent ;
	public  event Action ActionUpEvent ;

	// Use this for initialization
	void OnMouseDown() {
		offset = gameObject.transform.position - 
			Camera.main.ScreenToWorldPoint(
				new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		Cursor.visible = true;
		if(ActionDownEvent != null)
			ActionDownEvent();	
	}
	void OnMouseDrag() { 
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;


		if (gameObject.transform.name == "basket") {
		
			curPosition.x = Mathf.Clamp (curPosition.x,-1.43f,1.53f);
			curPosition.y = Mathf.Clamp (curPosition.y,-2.81f,-2.81f);
			gameObject.transform.position = curPosition;
		
		
		}

		if(ActionMoveEvent != null)
			ActionMoveEvent();	
	}

	void OnMouseUp(){
		Cursor.visible = true;

		if(ActionUpEvent != null)
			ActionUpEvent();
	}

}
