using UnityEngine;
using System.Collections;
using DG.Tweening;
public class SceneThree : MonoBehaviour {
	public Sprite gola;
	// Use this for initialization
	void Start () {


		StartCoroutine (bul());
		// Ads Code Start
		//		AdsHandler.Instance.ShowChartboost ();
		//		AdsHandler.Instance.ShowLeadboltAlert ();
		//		AdsHandler.Instance.ShowAdmobInterstitial();
		//		AdsHandler.Instance.LogScreenGoogleAnalytic ("  ");
		// Ads Code End
	}

	IEnumerator bul()
	{
		yield return new WaitForSeconds (4f);
		GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
		yield return new WaitForSeconds (2f);
		//DOTween.Play ("3");
		GameObject.Find("do1").transform.DOMove(GameObject.Find("d1").transform.position,1f,false);
		GameObject.Find("do2").transform.DOMove(GameObject.Find("d2").transform.position,1f,false);
		yield return new WaitForSeconds (2f);
		GameObject.Find ("fry").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (2f);
		GameObject.Find ("do1").GetComponent<SpriteRenderer> ().sprite = gola;
		GameObject.Find ("do2").GetComponent<SpriteRenderer> ().sprite = gola;
		yield return new WaitForSeconds (2f);
		GameObject.Find ("fry").GetComponent<AudioSource> ().Stop();
		yield return new WaitForSeconds (1f);
		GameObject.Find ("griddle_down").transform.DOMove (new Vector3 (0.12f, 1.96f, 0f), 1f, false);
		GameObject.Find ("spoon").transform.DOMove (new Vector2 (1.59f, -2.2f), 1f, false);
		//GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop();




	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Scene2");
			//			AdsHandler.Instance.InitializeAdmobInterstitial();
		}
	}

	public void frying()
	{
		StartCoroutine (frin());

	}

	IEnumerator frin()
	{

		yield return new WaitForSeconds (.3f);
		if (GameManager.Instance.fr == 1) {
			GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 6;
			GameObject.Find ("do1").GetComponent<SpriteRenderer> ().sortingOrder = 9;
			GameObject.Find ("do1").transform.parent = GameObject.Find ("spoon").transform;
			GameObject.Find ("do1").transform.DOLocalMove (new Vector2 (-0.2f, -0.57f), .5f, false);
			GameObject.Find ("do1").transform.DOScale (new Vector3(1.28f,1.28f,1.28f),0f);
			GameObject.Find ("p_btn_1").transform.position=GameObject.Find ("do1").transform.position;
			GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("do1").GetComponent<BoxCollider> ().enabled = false;
			yield return new WaitForSeconds (2f);
			GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 8;
			GameObject.Find ("spoon").transform.DOLocalMove (new Vector2 (0.55f, 3.13f), 1f, false);
			yield return new WaitForSeconds (2f);
			GameObject.Find ("do1").transform.DOLocalMove (new Vector2 (-0.43f, -1.51f), .5f, false);
			yield return new WaitForSeconds (.7f);
			GameObject.Find ("do1").transform.parent = null;
			GameObject.Find ("p_btn_1").transform.position=GameObject.Find ("do1").transform.position;
			GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			yield return new WaitForSeconds (.7f);
			GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 8;
			GameObject.Find ("spoon").transform.DOMove (new Vector2 (1.59f, -2.2f), 1f, false);
			GameObject.Find ("spoon").AddComponent<Drag> ();
			GameObject.Find ("do2").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.fr == 2) {
			GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 6;
			GameObject.Find ("do2").GetComponent<SpriteRenderer> ().sortingOrder = 9;
			GameObject.Find ("do2").transform.parent = GameObject.Find ("spoon").transform;
			GameObject.Find ("do2").transform.DOLocalMove (new Vector2 (-0.6f, -0.3f), .5f, false);
			GameObject.Find ("do2").transform.DOScale (new Vector3(1.28f,1.28f,1.28f),0f);
			GameObject.Find ("do2").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("p_btn_1").transform.position=GameObject.Find ("do2").transform.position;
			GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			yield return new WaitForSeconds (2f);
			GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 8;
			GameObject.Find ("spoon").transform.DOLocalMove (new Vector2 (1.13f, 2.84f), 1f, false);
			yield return new WaitForSeconds (2f);
			GameObject.Find ("do2").transform.DOMove (new Vector2 (0.56f, 2.08f), .5f, false);


			yield return new WaitForSeconds (.7f);
			GameObject.Find ("do2").transform.parent = null;
			GameObject.Find ("p_btn_1").transform.position=GameObject.Find ("do2").transform.position;
			GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			yield return new WaitForSeconds (.7f);
			GameObject.Find ("do2").transform.parent = GameObject.Find ("griddle_down").transform;
			GameObject.Find ("do1").transform.parent = GameObject.Find ("griddle_down").transform;
			GameObject.Find ("spoon").transform.DOMoveX (10f,1f,false);
			yield return new WaitForSeconds (.7f);
			GameObject.Find ("pan").transform.DOMoveX (-10f,1f,false);
			GameObject.Find ("stove").transform.DOMoveX (-10f,1f,false);
			DOTween.Play ("5");
			GameObject.Find ("griddle_down").AddComponent<Drag> ();
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
		GameManager.Instance.Sceconds = 2;
		Debug.Log (GameManager.Instance.Sceconds);
		yield return new WaitForSeconds (3f);
		Application.LoadLevel ("Loading1");
		//AdCalls.Instant.AdmobInterstitial();
	}
}
