using UnityEngine;
using System.Collections;

public class ExitDialog : MonoBehaviour {


	// Update is called once per frame
	void Update(){
		if (Input.GetKey (KeyCode.Escape)) {
			iTween.MoveTo(GameObject.Find("ExitDialog"), iTween.Hash ("x",0f,"time",0.5f,"easetype",iTween.EaseType.easeOutBack));
//			GameObject.Find("Play_Btn").GetComponent<tk2dButton>().enabled = false;
//			GameObject.Find("More_Btn").GetComponent<tk2dButton>().enabled = false;
			
		}
	}

	void NoBtn(){
		Application.Quit();
	}

	void YesBtn(){
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.panipure.indian.food.street.games");
		iTween.MoveTo(GameObject.Find("ExitDialog"), iTween.Hash ("x",-10f,"time",0.5f,"easetype",iTween.EaseType.easeOutBack));
//		GameObject.Find("Play_Btn").GetComponent<tk2dButton>().enabled = true;
//		GameObject.Find("Mroe_Btn").GetComponent<tk2dButton>().enabled = true;
	}
	void XBtn(){
		iTween.MoveTo(GameObject.Find("ExitDialog"), iTween.Hash ("x",-10f,"time",0.5f,"easetype",iTween.EaseType.easeOutBack));
//		AdsHandler.Instance.ShowAdmobInterstitial();
//		GameManager.Instance.TimerObject = 60f;
//		GameObject.Find("Play_Btn").GetComponent<tk2dButton>().enabled = true;
//		GameObject.Find("More_Btn").GetComponent<tk2dButton>().enabled = true;
		
	}

}
