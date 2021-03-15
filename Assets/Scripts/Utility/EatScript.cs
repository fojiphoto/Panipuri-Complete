using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


[RequireComponent(typeof(BoxCollider))]

public class EatScript : MonoBehaviour
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

        Cursor.visible = false;
        if (ActionDownEvent != null)
            ActionDownEvent();

    }

}
