using UnityEngine;
using System.Collections;

public class Paused_Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	//  Paused Fun
	void Paused_Fun(){
		Debug.Log ("Paused Fun Activate");
		iTween.ScaleTo(GameObject.Find ("P_Bg"),iTween.Hash("scale",new Vector3(1f,1f,1f),"time",0.5f,"easeType", iTween.EaseType.easeOutBack,"delay",0.5f));
		GameObject.Find ("Paused_Menu").GetComponent<tk2dButton> ().enabled = false;
		GameObject.Find ("P_Resume_X").GetComponent<tk2dButton> ().enabled = true;
	}

	// Resume Fun
	void Resume_Fun(){
		Debug.Log ("Resume Fun Activate");
		iTween.ScaleTo(GameObject.Find ("P_Bg"),iTween.Hash("scale",new Vector3(0f,0f,0f),"time",0.5f,"easeType", iTween.EaseType.easeInBack,"delay",0.5f));
		GameObject.Find ("Paused_Menu").GetComponent<tk2dButton> ().enabled = true;
		GameObject.Find ("P_Resume_X").GetComponent<tk2dButton> ().enabled = false;
	}

	// Home Fun
	IEnumerator Home_Fun(){
		Debug.Log ("Go to the Home Screen (MainMenu)");
//		AdsHandler.Instance.ShowChartboost ();
		yield return new WaitForSeconds (1f);
		Application.LoadLevel ("MainMenu");

	}

	// Back Fun
	IEnumerator Back_Fun(){
		Debug.Log ("Go to the Previous Page ");
//		AdsHandler.Instance.ShowChartboost ();
		yield return new WaitForSeconds (1f);
		Application.LoadLevel(Application.loadedLevel - 1);
		
	}

	// Restart Fun
	IEnumerator Restart_Fun(){
//		AdsHandler.Instance.ShowChartboost ();
		Debug.Log ("Reload the Current Scene ");
		yield return new WaitForSeconds (1f);
	//	Application.LoadLevel ("MainMenu");
		Application.LoadLevel(Application.loadedLevel);
	
	}

	// Social Links Buttons 
	void Social_Buttons(int button){
		switch(button){
		case 1:
			Debug.Log("Go To The Facebook Page");
			StartCoroutine ("Facebook_Page");
			break;
		case 2:
			Debug.Log("Go To The G+ Page");
			StartCoroutine ("G_Plus_Page");
			break;
		case 3:
			Debug.Log("Go To The More Games Link");
			StartCoroutine ("More_Page");
			break;

		}
	}
	
	IEnumerator Facebook_Page(){
		yield return new WaitForSeconds(0.5f);
		Application.OpenURL("https://www.facebook.com/Sky-Gaming-Studio-1494362297543434/");
	}
	IEnumerator G_Plus_Page(){
		yield return new WaitForSeconds(0.5f);
		Application.OpenURL("https://plus.google.com/u/0/+SkyGamingStudio");
	}
	IEnumerator More_Page(){
		yield return new WaitForSeconds(0.5f);
		Application.OpenURL("https://play.google.com/store/apps/dev?id=7823063335197231453");
	}

}
