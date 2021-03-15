using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

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
	
	}

	IEnumerator Play()
	{
		yield return new WaitForSeconds (.9f);
		GameManager.Instance.Scene_name = "Scene1";
		Application.LoadLevel ("Loading1");

	}

	IEnumerator moregames()
	{
		yield return new WaitForSeconds (.4f);

	}
	void privicy()
	{
		Application.OpenURL ("https://risegames8962.wixsite.com/website/privacypolicy");

	}
   public void NextLevel()
    {
	  //  AdCalls.Instant.AdmobInterstitial();

        SceneManager.LoadScene("Scene1");
    }
}
