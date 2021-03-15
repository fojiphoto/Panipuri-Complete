using UnityEngine;
using System.Collections;

public class SceneFour : MonoBehaviour {

	// Use this for initialization
	void Start () {


// Ads Code Start
//		AdsHandler.Instance.ShowChartboost ();
//		AdsHandler.Instance.ShowLeadboltAlert ();
//		AdsHandler.Instance.ShowAdmobInterstitial();
//		AdsHandler.Instance.LogScreenGoogleAnalytic ("  ");
// Ads Code End

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Scene3");
//			AdsHandler.Instance.InitializeAdmobInterstitial();
		}
	}
	IEnumerator home()
	{

		GameManager.Instance.Scene_name="MainMenu";
		yield return new WaitForSeconds (.5f);
		Application.LoadLevel ("Loading1");
	}
	IEnumerator next()
	{
		GameObject.Find ("NEXT").GetComponent<tk2dButton> ().enabled = false;
		GameObject.Find ("Final").GetComponent<ParticleSystem> ().Play ();
		GameObject.Find ("nicely").GetComponent<AudioSource> ().Play ();
		GameManager.Instance.Scene_name="MiniGame";
		GameManager.Instance.Sceconds = 3;
		yield return new WaitForSeconds (3f);
		Application.LoadLevel ("Loading1");
		//AdCalls.Instant.AdmobInterstitial();
	}
}
