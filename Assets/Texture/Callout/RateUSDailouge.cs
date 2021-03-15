using UnityEngine;
using System.Collections;

public class RateUSDailouge : MonoBehaviour {
	public GameObject CallOut;
	public AudioSource aSrc;
	// Use this for initialization
	void Awake () {
		CallOut.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ShowCallOut(){
		PlayerPrefs.SetInt ("ratecount",PlayerPrefs.GetInt ("ratecount")+1);
		if(PlayerPrefs.GetInt ("ratecount")%2 == 0 ){
			CallOut.SetActive (true);
			aSrc.Play ();
		}
		GameManager.Instance.b_isRateCall = false;
	}
	public void CloseCallOut(){
		GameManager.Instance.b_isRateCall = true;
		CallOut.SetActive (false);
	}
	public void RateUs(){
		Application.OpenURL ("https://play.google.com/store/apps/details?id="+Application.identifier);
	}

}
