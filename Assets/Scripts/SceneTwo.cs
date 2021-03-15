using UnityEngine;
using System.Collections;
using DG.Tweening;
public class SceneTwo : MonoBehaviour {

	public bool x,y,z;
	public Sprite douch;
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
			Application.LoadLevel ("Scene1");
//			AdsHandler.Instance.InitializeAdmobInterstitial();
		}
	}

	public void doch()
	{

		StartCoroutine (dc());


	}
	IEnumerator dc()
	{
		Debug.Log ("tol");
		yield return new WaitForSeconds (.5f);
		GameObject.Find ("dough_tool").transform.DORotate (new Vector3 (0f, 0f, -50f), .2f, RotateMode.Fast).SetLoops (3, LoopType.Yoyo);
		GameObject.Find ("cre").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (1f);
		if(GameManager.Instance.tool==1)
		{
			x = true;
			GameObject.Find ("line1").transform.parent = null;
			GameObject.Find ("line1").GetComponent<SpriteRenderer> ().sprite = douch;
			GameObject.Find ("line1").GetComponent<BoxCollider> ().enabled = false;
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("cup_faguang (1)").GetComponent<AudioSource> ().Play();
			GameObject.Find ("nicely done (1)").GetComponent<AudioSource> ().PlayDelayed(.3f);
		}
		if(GameManager.Instance.tool==2)
		{
			y = true;
			GameObject.Find ("line2").transform.parent = null;
			GameObject.Find ("line2").GetComponent<SpriteRenderer> ().sprite = douch;
			GameObject.Find ("line2").GetComponent<BoxCollider> ().enabled = false;

			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("cup_faguang (1)").GetComponent<AudioSource> ().Play();
			GameObject.Find ("nicely done (1)").GetComponent<AudioSource> ().PlayDelayed(.3f);
		}
		if(GameManager.Instance.tool==3)
		{
			z = true;
			GameObject.Find ("line3").transform.parent = null;
			GameObject.Find ("line3").GetComponent<SpriteRenderer> ().sprite = douch;
			GameObject.Find ("line3").GetComponent<BoxCollider> ().enabled = false;

			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("cup_faguang (1)").GetComponent<AudioSource> ().Play();
			GameObject.Find ("nicely done (1)").GetComponent<AudioSource> ().PlayDelayed(.3f);
		}
		yield return new WaitForSeconds (.3f);
		GameObject.Find ("dough_tool").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast);
		GameObject.Find ("dough_tool").transform.DOMove (GameObject.Find("plate2").transform.position,1f,false);
		yield return new WaitForSeconds (.3f);
		GameObject.Find ("dough_tool").AddComponent<Drag> ();
		if(x==true && y==true && z==true)
		{
			GameObject.Find ("plate2").transform.DOMoveX (-10f,1f,false);
			GameObject.Find ("dough_tool").transform.DOMoveX (-10f,1f,false);
			yield return new WaitForSeconds (.3f);
			GameObject.Find ("dough1").transform.DOMoveX (-10f,.5f,false);
			GameObject.Find ("line1").transform.DOLocalMove (new Vector3(0.01f,-0.51f,0f),1f,false);
			GameObject.Find ("line2").transform.DOLocalMove (new Vector3(0.54f,0.55f,0f),1f,false);
			GameObject.Find ("line3").transform.DOLocalMove (new Vector3(-0.7f,0.56f,0f),1f,false);
			GameObject.Find ("line1").transform.parent = GameObject.Find ("plate1").transform;
			GameObject.Find ("line2").transform.parent  = GameObject.Find ("plate1").transform;
			GameObject.Find ("line3").transform.parent  = GameObject.Find ("plate1").transform;
			yield return new WaitForSeconds (.3f);
			GameObject.Find ("f_board-01").transform.DOLocalMoveY (-10f,1f,false);
			yield return new WaitForSeconds (.3f);
			GameObject.Find ("plate1").transform.DOMove (new Vector3(-0.15f,-1.29f,0f),1f,false);
			GameObject.Find ("NEXT").transform.DOLocalMove (new Vector2(2.14f,2.72f),1f,false);

		}


	}

	public IEnumerator rol()
	{
		Debug.Log ("corotatire");
		yield return new WaitForSeconds (1f);
		GameObject.Find ("dough_tool").AddComponent<Drag> ();
		GameObject.Find ("dough_tool").GetComponent<iTween> ().enabled = true;
		GameObject.Find ("plate2").transform.DOMove(new Vector2(-1.83f,2.57f),1f,false);
		GameObject.Find ("line1").GetComponent<SpriteRenderer> ().enabled = true;
		GameObject.Find ("line2").GetComponent<SpriteRenderer> ().enabled = true;
		GameObject.Find ("line3").GetComponent<SpriteRenderer> ().enabled = true;
		GameObject.Find ("line1").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("line2").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("line3").GetComponent<BoxCollider> ().enabled = true;
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
		GameManager.Instance.Scene_name="Scene3";
		yield return new WaitForSeconds (3f);
		Application.LoadLevel ("Loading1");
	//	AdCalls.Instant.AdmobInterstitial();
	}
}
