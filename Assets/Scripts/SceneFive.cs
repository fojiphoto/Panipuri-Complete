using UnityEngine;
using System.Collections;
using DG.Tweening;
public class SceneFive : MonoBehaviour {
	public Sprite Lemoan,Lemoan2,Lemoan3,of;
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
			Application.LoadLevel ("Scene4");
//			AdsHandler.Instance.InitializeAdmobInterstitial();
		}
	}

	public void lemo()
	{

		StartCoroutine (Le());
	}
	IEnumerator Le()
	{
		yield return new WaitForSeconds (.2f);
		if (GameManager.Instance.lmo == 1) {
			GameObject.Find ("lemon1").GetComponent<SpriteRenderer> ().sprite = Lemoan;
			yield return new WaitForSeconds (.5f);
			GameObject.Find ("lm1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
			GameObject.Find ("lemon water").transform.DOScale (new Vector2 (1f, .5f), 4f).SetDelay (.5f);
			yield return new WaitForSeconds (.5f);
			GameObject.Find ("lemon1").GetComponent<SpriteRenderer> ().sprite = Lemoan2;
			yield return new WaitForSeconds (.7f);
			GameObject.Find ("lemon1").GetComponent<SpriteRenderer> ().sprite = Lemoan3;
			//GameObject.Find ("am").GetComponent<AudioSource> ().Play ();
			//GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("lemon1").transform.DOMoveX (8f, 1f).SetDelay (3.5f);
			GameObject.Find ("lemon2").AddComponent<Drag> ();
			GameObject.Find ("lemon2").GetComponent<ScaleBtnEffect>().enabled=true;
			yield return new WaitForSeconds (3f);
			GameObject.Find ("am").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();

		}
		if (GameManager.Instance.lmo == 2) {
			GameObject.Find ("lemon2").GetComponent<SpriteRenderer> ().sprite = Lemoan;
			yield return new WaitForSeconds (.5f);
			GameObject.Find ("lm2").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
			GameObject.Find ("lemon water").transform.DOScale (new Vector2 (1f, .8f), 4f).SetDelay (.5f);
			yield return new WaitForSeconds (.5f);
			GameObject.Find ("lemon2").GetComponent<SpriteRenderer> ().sprite = Lemoan2;
			yield return new WaitForSeconds (.7f);

			GameObject.Find ("lemon2").GetComponent<SpriteRenderer> ().sprite = Lemoan3;
			GameObject.Find ("lemon2").transform.DOMoveX (8f, 1f).SetDelay (3.5f);
			GameObject.Find ("lemon3").AddComponent<Drag> ();
			GameObject.Find ("lemon3").GetComponent<ScaleBtnEffect>().enabled=true;
			yield return new WaitForSeconds (3f);
			GameObject.Find ("am").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
		}
		if (GameManager.Instance.lmo == 3) {
			GameObject.Find ("lemon3").GetComponent<SpriteRenderer> ().sprite = Lemoan;
			yield return new WaitForSeconds (.5f);
			GameObject.Find ("lm3").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
			GameObject.Find ("lemon water").transform.DOScale (new Vector2 (1f, 1f), 4f).SetDelay (.5f);
			yield return new WaitForSeconds (.5f);
			GameObject.Find ("lemon3").GetComponent<SpriteRenderer> ().sprite = Lemoan2;
			yield return new WaitForSeconds (.7f);
			//GameObject.Find ("am").GetComponent<AudioSource> ().Play ();
			//GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("lemon3").GetComponent<SpriteRenderer> ().sprite = Lemoan3;
			GameObject.Find ("lemon3").transform.DOMoveX (8f, 1f).SetDelay (3.5f);
			GameObject.Find ("lemon bowl").transform.DOMoveX (-8f,1f);
			yield return new WaitForSeconds (3f);
			GameObject.Find ("am").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("Kaln bowl").AddComponent<Drag> ();
			GameObject.Find ("Kaln bowl").GetComponent<ScaleBtnEffect> ().enabled = true;
			GameManager.Instance.bl = 0;
		}
	}

	void btn()
	{
		GameObject.Find ("off").GetComponent<SpriteRenderer> ().sprite = GameObject.Find ("on2").GetComponent<SpriteRenderer> ().sprite;
		GameObject.Find ("off").GetComponent<tk2dButton> ().enabled = false;
		GameObject.Find ("finger (1)").GetComponent<SpriteRenderer> ().enabled = false;
		StartCoroutine (bt());


	}
	IEnumerator bt()
	{

		yield return new WaitForSeconds (.2f);
		GameObject.Find ("lemon water").transform.DOScale (new Vector2(0f,0f),0f);
		GameObject.Find ("kaln_layer").transform.DOScale (new Vector2(0f,0f),0f);
		GameObject.Find ("zera_layer").transform.DOScale (new Vector2(0f,0f),0f);
		GameObject.Find ("dhanva").transform.DOScale (new Vector2(0f,0f),0f);
		GameObject.Find ("pooden").transform.DOScale (new Vector2(0f,0f),0f);
		GameObject.Find ("mirch").transform.DOScale (new Vector2(0f,0f),0f);
		GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2(1f,1f),0f);
		GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
		GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Play ();
		GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Play ();
		yield return new WaitForSeconds (4.2f);
		GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Stop();
		GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop();
		GameObject.Find ("off").GetComponent<SpriteRenderer> ().sprite = of;
		yield return new WaitForSeconds (2f);
		GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
		GameObject.Find ("item2 (1)").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (.3f);
		GameObject.Find ("awesome (1)").GetComponent<AudioSource> ().Play ();
		DOTween.Play ("50");



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
		GameManager.Instance.Scene_name="Scene6";
		yield return new WaitForSeconds (3f);
		Application.LoadLevel ("Loading1");
		//AdCalls.Instant.AdmobInterstitial();
	}
		
}
