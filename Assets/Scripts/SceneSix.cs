using UnityEngine;
using System.Collections;
using DG.Tweening;
public class SceneSix : MonoBehaviour {
	public GameObject Tap;
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
			Application.LoadLevel ("Scene5");
			Destroy (GameObject.Find ("plates"));
		}

		//Debug.Log (GameObject.FindObjectOfType<Tap_colider> ().n);
//		if (GameObject.FindObjectOfType<Tap_colider> ().n >= 4) {
//
//			DOTween.Play ("26");
//		}
		}

	IEnumerator ok()
	{
		GameObject.Find ("Ok").GetComponent<tk2dButton> ().enabled = false;
		yield return new WaitForSeconds (.4f);
		Tap.SetActive (false);
		GameObject.Find ("p1").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("p2").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("p3").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("p4").GetComponent<BoxCollider> ().enabled = true;
		DOTween.Play ("1");

	}

	public void sp1()
	{
		StartCoroutine (p1());

	}
	IEnumerator p1()
	{
		yield return new WaitForSeconds (.2f);
		if (GameManager.Instance.bl == 1) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri1").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.p = 1;
		}
		if (GameManager.Instance.bl == 2) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri2").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.p = 2;
		}
		if (GameManager.Instance.bl == 3) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri3").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.p = 3;
		}
		if (GameManager.Instance.bl == 4) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri4").GetComponent<BoxCollider> ().enabled = true;
			//GameManager.Instance.p = 1;
		}
	}

	public void sp2()
	{
		StartCoroutine (p2());

	}

	IEnumerator p2()
	{
		yield return new WaitForSeconds (1f);
		if (GameManager.Instance.bl == 1) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("puri1").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.bl == 2) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("puri2").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.bl == 3) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("puri3").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.bl == 4) {
			GameObject.Find ("spoon1").AddComponent<Drag> ();
			GameObject.Find ("puri4").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("bowl").transform.DOMoveX (10f,1f,false);
			GameObject.Find ("spoon1").transform.DOMoveX (10f,1f,false).SetDelay(.5f);
			//GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.bl = 0;
			GameManager.Instance.p = 0;
			DOTween.Play ("25");
		}

	
	}
	public void sp3()
	{
		StartCoroutine (p3());

	}
	IEnumerator p3()
	{
		yield return new WaitForSeconds (.2f);
		if (GameManager.Instance.bl == 1) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri1").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.p = 1;
		}
		if (GameManager.Instance.bl == 2) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri2").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.p = 2;
		}
		if (GameManager.Instance.bl == 3) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri3").GetComponent<BoxCollider> ().enabled = true;
			GameManager.Instance.p = 3;
		}
		if (GameManager.Instance.bl == 4) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 23;
			GameObject.Find ("puri4").GetComponent<BoxCollider> ().enabled = true;
			//GameManager.Instance.p = 1;
		}
	}

	public void sp4()
	{
		StartCoroutine (p4());

	}

	IEnumerator p4()
	{
		yield return new WaitForSeconds (1f);
		if (GameManager.Instance.bl == 1) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("puri1").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.bl == 2) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("puri2").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.bl == 3) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("puri3").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = true;
		}
		if (GameManager.Instance.bl == 4) {
			GameObject.Find ("spoon2").AddComponent<Drag> ();
			GameObject.Find ("puri4").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = false;
			GameManager.Instance.bl = 0;
			GameManager.Instance.p = 0;
			GameObject.Find ("BOWL-1").transform.DOMoveX (10f,1f,false);
			GameObject.Find ("spoon2").transform.DOMoveX (10f,1f,false).SetDelay(.5f);
			DOTween.Play ("50");
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
		//GameManager.Instance.Scene_name="Scene2";
		yield return new WaitForSeconds (3f);
		Application.LoadLevel ("LastScene");
		//AdCalls.Instant.AdmobInterstitial();
	}
}
