using UnityEngine;
using System.Collections;
using DG.Tweening;
public class loading_br : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Loading());
		if (AdCalls.Instant != null)
		{
			AdCalls.Instant.AdmobInterstitial();
		}



	// Ads Code Start
	//		AdsHandler.Instance.ShowChartboost ();
	//		AdsHandler.Instance.ShowLeadboltAlert ();
	//		AdsHandler.Instance.ShowAdmobInterstitial();
	//		AdsHandler.Instance.LogScreenGoogleAnalytic ("  ");
	// Ads Code End
	}
	IEnumerator Loading()
	{
		yield return new WaitForSeconds (.1f);
		//GameObject.Find ("1").GetComponent<MeshRenderer> ().enabled = true;
	//	GameObject.Find ("2").GetComponent<MeshRenderer> ().enabled = true;
	//	GameObject.Find ("3").GetComponent<MeshRenderer> ().enabled = true;
		yield return new WaitForSeconds (.1f);
		GameObject.Find ("l").transform.DOScaleX(1f,3f);
		yield return new WaitForSeconds (3.2f);
		StartCoroutine (Scene_load());
	
	}


	IEnumerator Scene_load()
	{
		if (GameManager.Instance.Scene_name == null) {
			Application.LoadLevel ("Menu");

		}

		if (GameManager.Instance.Scene_name == "Menu") {
            //DMAD.Instance.ShowInterstitial ("ads");
            //AdManager.Instance.ShowSequence(0);
			Destroy( GameObject.Find("bg2"));
			yield return new WaitForSeconds (.3f);
			Application.LoadLevel ("Menu");

		}
		if (GameManager.Instance.Scene_name == "Scene1") {
            //DMAD.Instance.ShowInterstitial ("ads");
           // AdManager.Instance.ShowSequence(1);
            yield return new WaitForSeconds (.3f);
			Application.LoadLevel ("Scene1");
		
		}
		if (GameManager.Instance.Scene_name == "Scene2") {
            //DMAD.Instance.ShowInterstitial ("ads");
            //AdManager.Instance.ShowSequence(0);
            yield return new WaitForSeconds (.3f);
			Application.LoadLevel ("Scene2");

		}
		if (GameManager.Instance.Scene_name == "Scene3") {
			Application.LoadLevel ("Scene3");

		}
		if (GameManager.Instance.Scene_name == "Scene4") {
            //DMAD.Instance.ShowInterstitial ("ads");
           // AdManager.Instance.ShowSequence(0);
            yield return new WaitForSeconds (.3f);
			Application.LoadLevel ("Scene4");

		}
		if (GameManager.Instance.Scene_name == "Scene5") {
			Application.LoadLevel ("Scene5");

		}
		if (GameManager.Instance.Scene_name == "Scene6") {
            //DMAD.Instance.ShowInterstitial ("ads");
           // AdManager.Instance.ShowSequence(1);
            yield return new WaitForSeconds (.3f);
			Application.LoadLevel ("Scene6");

		}
		if (GameManager.Instance.Scene_name == "Scene7") {
			Application.LoadLevel ("Scene7");

		}
		if (GameManager.Instance.Scene_name == "Scene8") {
			Application.LoadLevel ("Scene8");

		}
		if (GameManager.Instance.Scene_name == "MiniGame") {
			Application.LoadLevel ("MiniGame");

		}

	
	
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel (Application.loadedLevel - 1);
			AdCalls.Instant.AdmobInterstitial();

		}
	}
}
