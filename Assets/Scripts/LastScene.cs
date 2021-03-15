using UnityEngine;
using System.Collections;
using DG.Tweening;
public class LastScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject.Find ("plates").transform.DOLocalMove (new Vector2(-1.07f,-2.09f),1f,false);
		GameObject.Find ("plates").GetComponent<BoxCollider> ().enabled = true;
		GameObject.Find ("plates").GetComponent<SpriteRenderer> ().sortingOrder = 4;
		//GameManager.Instance.b_isRateCall = true;
		//StartCoroutine ("RateUsCall");
	}

	IEnumerator RateUsCall(){
		yield return new WaitForSeconds (3f);
		FindObjectOfType<RateUSDailouge> ().ShowCallOut ();
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Scene6");
			Destroy (GameObject.Find ("plates"));
		}
	}

	IEnumerator home()
	{
		Destroy (GameObject.Find ("plates"));
		GameManager.Instance.Scene_name="MainMenu";
		GameObject.Find ("Home").GetComponent<tk2dButton> ().enabled = false;
		GameObject.Find ("Final").GetComponent<ParticleSystem> ().Play ();
		GameObject.Find ("nicely").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (3f);
		Application.LoadLevel ("Loading1");
	}
	void rateus()
	{
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.panipure.indian.food.street.games");
	}
	void moregames()
	{


	}
}
