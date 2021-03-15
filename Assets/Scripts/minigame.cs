using UnityEngine;
using System.Collections;
using DG.Tweening;
public class minigame : MonoBehaviour {
	public GameObject[] Toyes;

	public GameObject Note,Note2,Note3,coin,Replay,Replay1,Replay2;
	public static float timer=0f;
	public static int mints=0;
	public  bool t=false;
	public float timeDelay=1;
	int speed;
	//public GameObject start_toy;
	int i,coin_value;
	// Use this for initialization
	void Start () {
		//GameManager.Instance.Sceconds = 3;
		Debug.Log (GameManager.Instance.Sceconds);
		coinmove.j = 0;
		if (GameManager.Instance.Sceconds == 1) {
			timer = 60f;
			//GameObject.Find ("text").GetComponent<tk2dTextMesh> ().text = PlayerPrefs.GetInt ("coin").ToString ();
			GameObject.Find ("tm").GetComponent<tk2dTextMesh> ().text = Mathf.Round (timer).ToString ();
			Note.SetActive (true);
		}
		if (GameManager.Instance.Sceconds == 2) {
			timer = 60f;
			mints = 1;
			//GameObject.Find ("text").GetComponent<tk2dTextMesh> ().text = PlayerPrefs.GetInt ("coin").ToString ();
			GameObject.Find ("tm").GetComponent<tk2dTextMesh> ().text = Mathf.Round (timer).ToString ();
			Note2.SetActive (true);
		}
		if (GameManager.Instance.Sceconds == 3) {
			timer = 60f;
			mints = 2;
			GameObject.Find ("mint").GetComponent<tk2dTextMesh> ().text ="0"+ mints.ToString ()+":";
			//GameObject.Find ("text").GetComponent<tk2dTextMesh> ().text = PlayerPrefs.GetInt ("coin").ToString ();
			GameObject.Find ("tm").GetComponent<tk2dTextMesh> ().text = Mathf.Round (timer).ToString ();
			Note3.SetActive (true);
		}

// Ads Code Start
//		AdsHandler.Instance.ShowChartboost ();
//		AdsHandler.Instance.ShowLeadboltAlert ();
//		AdsHandler.Instance.ShowAdmobInterstitial();
//		AdsHandler.Instance.LogScreenGoogleAnalytic ("  ");
// Ads Code End

	}

	IEnumerator Ok()
	{
		if (GameManager.Instance.Sceconds == 1) {
			Note.SetActive (false);
			yield return new WaitForSeconds (.3f);
			StartCoroutine (Toy ());
			t = true;
		}
		if (GameManager.Instance.Sceconds == 2) {
			Note2.SetActive (false);
			yield return new WaitForSeconds (.3f);
			StartCoroutine (Toy ());
			t = true;
		}
		if (GameManager.Instance.Sceconds == 3) {
			Note3.SetActive (false);
			yield return new WaitForSeconds (.3f);
			StartCoroutine (Toy ());
			t = true;
		}
	
	}

	IEnumerator Toy()
	{
		i = Random.Range (0, Toyes.Length);
		yield return new WaitForSeconds (timeDelay);
		GameObject ob= Instantiate (Toyes[i],new Vector3( Random.Range(-2.73f,2.53f),Random.Range(10.08f,10.08f),0f),Quaternion.identity) as GameObject;
		//ob.transform.position.x = transform.position.x + 2f * Time.deltaTime;
		yield return new WaitForSeconds (.9f);
		StartCoroutine (Toy());

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Scene3");
//			AdsHandler.Instance.InitializeAdmobInterstitial();
			//Destroy (GameObject.Find ("plate"));
		}
		coin_value = int.Parse( GameObject.Find ("text").GetComponent<tk2dTextMesh> ().text);
		if (t == true) {
			timer -= Time.deltaTime;
			if (timer < 0) {

			
				if (GameManager.Instance.Sceconds == 1) {
					if (coin_value < 15) {
						Debug.Log (timer);
						//StartCoroutine (coin_chacker ());
						StopAllCoroutines ();
						GameObject.FindObjectOfType<minigame> ().Replay1.SetActive (true);
						GameObject.FindObjectOfType<minigame> ().t = false;
						GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
						GameObject.Find ("basket").GetComponent<BoxCollider2D> ().enabled = false;

					}
				}
				if (GameManager.Instance.Sceconds == 2) {
					if (coin_value < 30) {
						Debug.Log (timer);
						//StartCoroutine (coin_chacker ());
						StopAllCoroutines ();
						GameObject.FindObjectOfType<minigame> ().Replay1.SetActive (true);
						GameObject.FindObjectOfType<minigame> ().t = false;
						GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
						GameObject.Find ("basket").GetComponent<BoxCollider2D> ().enabled = false;

					}
				}
//				if (GameManager.Instance.Sceconds == 3) {
//					if (coin_value < 60) {
//						Debug.Log (timer);
//						//StartCoroutine (coin_chacker ());
//						StopAllCoroutines ();
//						GameObject.FindObjectOfType<minigame> ().Replay1.SetActive (true);
//						GameObject.FindObjectOfType<minigame> ().t = false;
//						GameObject.Find ("colider").GetComponent<BoxCollider> ().enabled = false;
//						GameObject.Find ("basket").GetComponent<BoxCollider> ().enabled = false;
//
//					}
				}
			if (mints > 0 && timer<0) {
					mints--;
					timer = 60f;
					GameObject.Find ("mint").GetComponent<tk2dTextMesh> ().text = "0" + mints.ToString () + ":";
				
				}
				if (mints < 0) {
					mints = 0;
					timer = 0f;
					GameObject.Find ("mint").GetComponent<tk2dTextMesh> ().text = "0" + 0.ToString ();
					GameObject.Find ("tm").GetComponent<tk2dTextMesh> ().text = "0";
				if (GameManager.Instance.Sceconds == 3) {
					if (coin_value < 60) {
						Debug.Log (timer);
						//StartCoroutine (coin_chacker ());
						StopAllCoroutines ();
						GameObject.FindObjectOfType<minigame> ().Replay1.SetActive (true);
						GameObject.FindObjectOfType<minigame> ().t = false;
						GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
						GameObject.Find ("basket").GetComponent<BoxCollider2D> ().enabled = false;

					}

				
//					GameObject.FindObjectOfType<minigame> ().StopAllCoroutines ();
//					//GameObject.Find ("wrong").GetComponent<AudioSource> ().Play ();
//					GameObject.FindObjectOfType<minigame> ().Replay.SetActive (true);
//					GameObject.FindObjectOfType<minigame> ().t = false;
//					GameObject.Find ("colider").GetComponent<BoxCollider> ().enabled = false;
//					GameObject.Find ("basket").GetComponent<BoxCollider>().enabled=false;
				}
			}
			if (timer > 0  ) {

				GameObject.Find ("tm").GetComponent<tk2dTextMesh> ().text = Mathf.Round (timer).ToString ();
			
			
			
			}
	
		}
		StartCoroutine (coin_chacker ());
		if (mints > 0 && timer>0) {
			StartCoroutine (coin_chacker ());
		}
	
	}

	IEnumerator replay()
	{
		t = false;
		GameObject.Find ("mint").GetComponent<tk2dTextMesh> ().text = "0" + 0.ToString ();
		GameObject.Find ("tm").GetComponent<tk2dTextMesh> ().text = "0";
		yield return new WaitForSeconds (.5f);
		Application.LoadLevel (Application.loadedLevel);

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

		if (GameManager.Instance.Sceconds == 1) {
			GameManager.Instance.Scene_name="Scene2";
			Debug.Log (GameManager.Instance.Sceconds);
			Application.LoadLevel ("Loading1");
			yield return new WaitForSeconds (1f);

		}
		if (GameManager.Instance.Sceconds == 2) {
			GameManager.Instance.Scene_name="Scene4";
			Debug.Log (GameManager.Instance.Sceconds);
			Application.LoadLevel ("Loading1");
			yield return new WaitForSeconds (1f);
		
		}
		if (GameManager.Instance.Sceconds == 3) {
			GameManager.Instance.Scene_name="Scene5";
			Debug.Log (GameManager.Instance.Sceconds);
			Application.LoadLevel ("Loading1");
			yield return new WaitForSeconds (1f);


		}
		//GameObject.Find ("nicely").GetComponent<AudioSource> ().Play ();
		//GameManager.Instance.Scene_name="Scene4";
	
	
	}

	IEnumerator coin_chacker()
	{

		yield return new WaitForSeconds (0f);
		if (GameManager.Instance.Sceconds == 1) {
		
			if (coin_value >= 15) {
				StopAllCoroutines ();
				GameObject.FindObjectOfType<minigame> ().Replay2.SetActive (true);
				GameObject.FindObjectOfType<minigame> ().t = false;
				GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
				GameObject.Find ("basket").GetComponent<BoxCollider2D> ().enabled = false;

			} 
		}
		if (GameManager.Instance.Sceconds == 2) {

			if (coin_value >= 30) {
				StopAllCoroutines ();
				GameObject.FindObjectOfType<minigame> ().Replay2.SetActive (true);
				GameObject.FindObjectOfType<minigame> ().t = false;
				GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
				GameObject.Find ("basket").GetComponent<BoxCollider2D> ().enabled = false;

			} 
		}
		if (GameManager.Instance.Sceconds == 3) {

			if (coin_value >= 45) {
				StopAllCoroutines ();
				GameObject.FindObjectOfType<minigame> ().Replay2.SetActive (true);
				GameObject.FindObjectOfType<minigame> ().t = false;
				GameObject.Find ("colider").GetComponent<BoxCollider2D> ().enabled = false;
				GameObject.Find ("basket").GetComponent<BoxCollider2D> ().enabled = false;

			} 
		}
	}


}
