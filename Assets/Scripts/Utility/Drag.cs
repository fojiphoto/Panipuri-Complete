using UnityEngine;
using System.Collections;
using System; 
using DG.Tweening;
[RequireComponent(typeof(BoxCollider))]

public class Drag : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	public  event Action ActionDownEvent ;
	public  event Action ActionMoveEvent ;
	public  event Action ActionUpEvent ;
	Vector3 pos,pos2;

	bool a,b,x,y,z,t;
	//On action down of the sprite/gameobject .
	void OnMouseDown() {
		offset = gameObject.transform.position - 
				Camera.main.ScreenToWorldPoint(
					new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		Cursor.visible = true;
		if (gameObject.transform.name == "lemon1") {
			GameObject.Find ("finger (2)").GetComponent<SpriteRenderer> ().enabled = false;
		
			GameObject.Find ("lemon1").GetComponent<SpriteRenderer> ().sortingOrder = 12;
		}
		if (gameObject.transform.name == "lemon2") {

			GameObject.Find ("lemon2").GetComponent<SpriteRenderer> ().sortingOrder = 12;
		}	if (gameObject.transform.name == "lemon3") {

			GameObject.Find ("lemon3").GetComponent<SpriteRenderer> ().sortingOrder = 12;
		}
	
		
	

		pos = gameObject.transform.position;
		if(ActionDownEvent != null)
				ActionDownEvent();	

	}
	//On action drag of the sprite/gameobject .
	void OnMouseDrag() { 
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;

		if (gameObject.transform.name == "water1") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("finger").GetComponent<SpriteRenderer> ().enabled = false;
				GameObject.Find ("water1").transform.parent = null;
				GameObject.Find ("water_hand").transform.DOMoveX (10f,1f,false);
				Destroy (GameObject.Find ("water1").GetComponent<Drag> ());
				GameObject.Find ("water1").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f).OnComplete(jug);
				GameObject.Find ("water1").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);
				GameObject.Find ("water1").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				//GameObject.Find ("onion").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(1.2f);
				GameObject.Find ("water1_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("water_sound").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("water_layer").transform.DOScale (new Vector2(1.051057f,1.051057f),2f).SetDelay(1f).OnComplete(partical);
				//GameObject.Find ("fry").GetComponent<AudioSource> ().PlayDelayed (3f);
				//GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("water1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f).OnComplete(jug1);
				GameObject.Find ("water1").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("3");
			}
		}
		if (gameObject.transform.name == "flour") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("flour").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("flour").transform.parent = null;
				GameObject.Find ("flour_hand").transform.DOMoveX (10f,1f,false);
				Destroy (GameObject.Find ("flour").GetComponent<Drag> ());
				GameObject.Find ("flour").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("flour").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				//GameObject.Find ("onion").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(1.2f);
				GameObject.Find ("flour_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("flour_layer").transform.DOScale (new Vector2(1.051057f,1.051057f),2f).SetDelay(1f).OnComplete(partical);
				//GameObject.Find ("fry").GetComponent<AudioSource> ().PlayDelayed (3f);
				//GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("flour").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("flour").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("4");
			}
		}
		if (gameObject.transform.name == "suji") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("suji").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("suji").transform.parent = null;
				GameObject.Find ("suji_hand").transform.DOMoveX (10f,1f,false);
				Destroy (GameObject.Find ("suji").GetComponent<Drag> ());
				GameObject.Find ("suji").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("suji").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				//GameObject.Find ("onion").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(1.2f);
				GameObject.Find ("suji_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("Su").GetComponent<AudioSource> ().PlayDelayed (.3f);
				GameObject.Find ("suji_layer").transform.DOScale (new Vector2(1.051057f,1.051057f),2f).SetDelay(1f).OnComplete(partical);
				//GameObject.Find ("fry").GetComponent<AudioSource> ().PlayDelayed (3f);
				//GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("suji").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("suji").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("5");
			}
		}

		if (gameObject.transform.name == "salt") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("salt").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("salt").transform.parent = null;
				GameObject.Find ("salt_hand").transform.DOMoveX (10f,1f,false);
				Destroy (GameObject.Find ("salt").GetComponent<Drag> ());
				GameObject.Find ("salt").transform.DORotate (new Vector3 (0f, 0f, 80f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("salt").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				//GameObject.Find ("onion").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(1.2f);
				GameObject.Find ("salt_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("Su").GetComponent<AudioSource> ().PlayDelayed (.3f);
				GameObject.Find ("salt_layer").transform.DOScale (new Vector2(1.051057f,1.051057f),2f).SetDelay(.6f).OnComplete(partical);
				//GameObject.Find ("fry").GetComponent<AudioSource> ().PlayDelayed (3f);
				//GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("salt").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("salt").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("6");
			}
		}

		if (gameObject.transform.name == "blender") {

			curPosition.x = Mathf.Clamp (curPosition.x,-0.03f,1.67f);
			curPosition.y = Mathf.Clamp (curPosition.y,-0.75f,-0.87f);
			gameObject.transform.position = curPosition;

			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");

				pos2 = gameObject.transform.position;

				if (!GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().isPlaying) {

					GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Play ();

				}
				//if (!GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().isPlaying) {



				//}
				//GameObject.Find ("Spoon2").transform.DORotate (new Vector3 (0f, 0f, 24f), 0f, RotateMode.Fast);

				if (GameObject.Find ("Mixing_layer").GetComponent<tk2dSprite> ().CurrentSprite.name == "mixxing-6") {

					//GameObject.Find ("Mixing_layer").GetComponent<Animator> ().enabled = false;
					GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Pause ();
					GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().Stop();
					GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop();
					Destroy (GameObject.Find("blender").GetComponent<Drag>());
					GameObject.Find ("blender").transform.DOMoveY (2f, 1f).SetDelay (.3f);
					GameObject.Find ("blender").transform.DOMoveX (8f, 1f).SetDelay (.5f).OnComplete(partical);
					GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop ();
					GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Stop();
					GameObject.Find ("amezing (1)").GetComponent<AudioSource> ().Play ();
					DOTween.Play ("50");
					DOTween.Play ("30");


				}

				else {
					GameObject.Find ("blender").GetComponent<tk2dSprite> ().SortingOrder = 8;
					GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().Play ();
					GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2(1f,1f),.5f);
					//GameObject.Find ("Mixing_layer").GetComponent<Animator> ().enabled = true;
					GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Play ();
					GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Resume();
					GameObject.Find ("water_layer").transform.DOScale (new Vector2(0f,0f),.5f);
					GameObject.Find ("flour_layer").transform.DOScale (new Vector2(0f,0f),.5f);
					GameObject.Find ("salt_layer").transform.DOScale (new Vector2(0f,0f),.5f);
					GameObject.Find ("suji_layer").transform.DOScale (new Vector2(0f,0f),.5f);
			

					GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();

				}


			}
		}
		// Rolling
		if (gameObject.transform.name == "rolling") {


			curPosition.x = Mathf.Clamp (curPosition.x,0.07f,0.07f);
			curPosition.y = Mathf.Clamp (curPosition.y,-3.38f,-1.4f);
			gameObject.transform.position = curPosition;


			if (curPosition.x > GameObject.Find ("dough1").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("dough1").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("dough1").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("dough1").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				DOTween.PlayForwardAll ();
				if (!GameObject.Find ("ro").GetComponent<AudioSource> ().isPlaying) {

					GameObject.Find ("ro").GetComponent<AudioSource> ().Play ();

				}
				GameObject.Find ("rolling").GetComponent<iTween> ().enabled = false;
				//0.615374
				//GameObject.Find ("dough2").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(.6f);
				//GameObject.Find ("dough3").transform.DOScale (new Vector2(1f,1f),3f).SetDelay(.6f);
				GameObject.Find ("dough4").transform.DOScale (new Vector2(1f,1f),4f).SetDelay(.6f).OnComplete(rolarmove);
	

			}
		}

		if (gameObject.transform.name == "dough_tool") {




			if (curPosition.x > GameObject.Find ("line1").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("line1").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("line1").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("line1").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.tool = 1;
				Destroy (GameObject.Find ("dough_tool").GetComponent<Drag> ());
				GameObject.Find ("dough_tool").GetComponent<iTween> ().enabled = false;
				//0.615374
				GameObject.Find("dough_tool").transform.DOMove(GameObject.Find("line1").transform.position,0f,false).OnComplete(tool);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("line1").transform.position;
				GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();

			}
			if (curPosition.x > GameObject.Find ("line2").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("line2").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("line2").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("line2").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.tool = 2;
				Destroy (GameObject.Find ("dough_tool").GetComponent<Drag> ());
				GameObject.Find ("dough_tool").GetComponent<iTween> ().enabled = false;
				//0.615374
				GameObject.Find("dough_tool").transform.DOMove(GameObject.Find("line2").transform.position,0f,false).OnComplete(tool);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("line2").transform.position;
				GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();

			}
			if (curPosition.x > GameObject.Find ("line3").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("line3").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("line3").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("line3").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.tool = 3;
				Destroy (GameObject.Find ("dough_tool").GetComponent<Drag> ());
				GameObject.Find ("dough_tool").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("dianji_hezi (1)").GetComponent<AudioSource> ().Play ();
				//0.615374
				GameObject.Find("dough_tool").transform.DOMove(GameObject.Find("line3").transform.position,0f,false).OnComplete(tool);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("line3").transform.position;

			}
		}

		if (gameObject.transform.name == "spoon") {




			if (curPosition.x > GameObject.Find ("do1").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("do1").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("do1").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("do1").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.fr = 1;
				Destroy (GameObject.Find ("spoon").GetComponent<Drag> ());
				//GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 6;
				GameObject.Find ("spoon").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("spoon").transform.DOLocalMove (new Vector3(1.03f,0.16f,0f),.5f,false).OnComplete(fr);
			

			}
			if (curPosition.x > GameObject.Find ("do2").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("do2").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("do2").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("do2").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.fr = 2;
				Destroy (GameObject.Find ("spoon").GetComponent<Drag> ());
				//GameObject.Find ("spoon").GetComponent<SpriteRenderer> ().sortingOrder = 6;
				GameObject.Find ("spoon").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("spoon").transform.DOLocalMove (new Vector3(-0.19f,0.09f,0f),.5f,false).OnComplete(fr);


			}
		}
		if (gameObject.transform.name == "griddle_down") {




			if (curPosition.x > GameObject.Find ("hand").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("hand").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("hand").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("hand").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
			
				Destroy (GameObject.Find ("griddle_down").GetComponent<Drag> ());

				GameObject.Find ("griddle_down").transform.DOMove (new Vector2(0.33f,1.83f),0f,false);
				GameObject.Find ("griddle_down").transform.DORotate (new Vector3(0f,0f,40.89f),1f,RotateMode.Fast).SetDelay(.2f);
				GameObject.Find ("do2").transform.DOMove (new Vector2 (-1.85f, 0.56f), 1f, false).SetDelay(1.3f);
				GameObject.Find ("do1").transform.DOMove (new Vector2 (-0.762f, 0.469f), 1f, false).SetDelay(1.7f).OnComplete(tl);



			}
		}

		// mixing2

		if (gameObject.transform.name == "chany bowl") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
			//	GameObject.Find ("chany bowl").GetComponent<iTween> ().enabled = false;
			//	GameObject.Find ("chany bowl").transform.parent = null;
				//GameObject.Find ("flour_hand").transform.DOMoveX (10f,1f,false);
				Destroy (GameObject.Find ("chany bowl").GetComponent<Drag> ());
				GameObject.Find ("chany bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("chany bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				//GameObject.Find ("onion").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(1.2f);
				GameObject.Find ("chnay_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("chnay").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				GameObject.Find ("chnay_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);
				//GameObject.Find ("fry").GetComponent<AudioSource> ().PlayDelayed (3f);
				//GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("chany bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("chany bowl").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("3");
			}
		}


		if (gameObject.transform.name == "masla bowl") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
			
				Destroy (GameObject.Find ("masla bowl").GetComponent<Drag> ());
				GameObject.Find ("masla bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("masla bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);

				GameObject.Find ("masla_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("masla").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				GameObject.Find ("masla_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);
			
				GameObject.Find ("masla bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("masla bowl").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("4");
			}
		}

		if (gameObject.transform.name == "zera bowl") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");

				Destroy (GameObject.Find ("zera bowl").GetComponent<Drag> ());
				GameObject.Find ("zera bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("zera bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);

				GameObject.Find ("zera_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("zera").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				GameObject.Find ("zera_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("zera bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("zera bowl").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("5");
			}
		}

		if (gameObject.transform.name == "tomato bowl") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");

				Destroy (GameObject.Find ("tomato bowl").GetComponent<Drag> ());
				GameObject.Find ("tomato bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("tomato bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);

				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);

				GameObject.Find ("tomato_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add_powder").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("tomato").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				GameObject.Find ("tomato_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("tomato bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("tomato bowl").transform.DOMoveX (8f,1f).SetDelay(3.9f);
				DOTween.Play ("6");
			}
		}

		if (gameObject.transform.name == "Blender") {

			curPosition.x = Mathf.Clamp (curPosition.x,0.14f,2.484422f);
			curPosition.y = Mathf.Clamp (curPosition.y,-0.1f,0.2367185f);
			gameObject.transform.position = curPosition;

//			if (curPosition.x > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.x &&
//				curPosition.y > GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.min.y &&
//				curPosition.x < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.x &&
//				curPosition.y < GameObject.Find ("bowl").GetComponent<SpriteRenderer> ().bounds.max.y) 
			{
				Debug.Log ("in bowl");

				pos2 = gameObject.transform.position;

				if (!GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().isPlaying) {

					GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Play ();

				}
				//if (!GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().isPlaying) {



				//}
				//GameObject.Find ("Spoon2").transform.DORotate (new Vector3 (0f, 0f, 24f), 0f, RotateMode.Fast);

				if (GameObject.Find ("Mixing_layer").GetComponent<tk2dSprite> ().CurrentSprite.name == "mix4") {

					//GameObject.Find ("Mixing_layer").GetComponent<Animator> ().enabled = false;
					GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Pause ();
					GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().Stop();
					GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop();
					Destroy (GameObject.Find("Blender").GetComponent<Drag>());
					GameObject.Find ("Blender").transform.DOMoveY (2f, 1f).SetDelay (.3f);
					GameObject.Find ("Blender").transform.DOMoveX (8f, 1f).SetDelay (.5f).OnComplete(partical);
					GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop ();
					GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Stop();
					GameObject.Find ("amezing (1)").GetComponent<AudioSource> ().Play ();
					DOTween.Play ("12");
					DOTween.Play ("30");
					DOTween.Play ("50");


				}

				else {
					GameObject.Find ("blender").GetComponent<tk2dSprite> ().SortingOrder = 9;
					GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().Play ();
					GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2(1f,1f),.5f);
					//GameObject.Find ("Mixing_layer").GetComponent<Animator> ().enabled = true;
					GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Play ();
					GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Resume();
					GameObject.Find ("chnay_layer").transform.DOScale (new Vector2(0f,0f),.5f);
					GameObject.Find ("masla_layer").transform.DOScale (new Vector2(0f,0f),.5f);
					GameObject.Find ("zera_layer").transform.DOScale (new Vector2(0f,0f),.5f);
					GameObject.Find ("tomato_layer").transform.DOScale (new Vector2(0f,0f),.5f);


					GameObject.Find ("bul").GetComponent<ParticleSystem> ().Play ();

				}


			}
		}

		// Blender ecene5
		if (gameObject.transform.name == "lemon1") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.lmo = 1;
				GameObject.Find ("lemon1").GetComponent<iTween> ().enabled = false;
				GameObject.Find ("lemon1").transform.parent = null;
				Destroy (GameObject.Find ("lemon1").GetComponent<Drag> ());

				GameObject.Find ("lemon1").transform.DOMove (GameObject.Find("E").transform.position,.4f,false).OnComplete(Lemo);

			}
		}
		if (gameObject.transform.name == "lemon2") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.lmo = 2;
				GameObject.Find ("lemon2").transform.parent = null;

				GameObject.Find ("lemon2").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("lemon2").GetComponent<Drag> ());

				GameObject.Find ("lemon2").transform.DOMove (GameObject.Find("E").transform.position,.4f,false).OnComplete(Lemo);

			}
		}
		if (gameObject.transform.name == "lemon3") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameManager.Instance.lmo = 3;
				GameObject.Find ("lemon3").transform.parent = null;

				GameObject.Find ("lemon3").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("lemon3").GetComponent<Drag> ());

				GameObject.Find ("lemon3").transform.DOMove (GameObject.Find("E").transform.position,.4f,false).OnComplete(Lemo);

			}
		}


		if (gameObject.transform.name == "Kaln bowl") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("Kaln bowl").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("Kaln bowl").GetComponent<Drag> ());
				GameObject.Find ("Kaln bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("Kaln bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);
				GameManager.Instance.bl = 1;
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);

				GameObject.Find ("kl_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("klane").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				GameObject.Find ("kaln_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("Kaln bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(3.5f);
				GameObject.Find ("Kaln bowl").transform.DOMoveX (8f,1f).SetDelay(3.9f).OnComplete(bow);
				DOTween.Play ("6");
			}
		}

		if (gameObject.transform.name == "dhanva bowl") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("dhanva bowl").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("dhanva bowl").GetComponent<Drag> ());
				GameObject.Find ("dhanva bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("dhanva bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);
				GameManager.Instance.bl = 2;
				//GameObject.Find ("dhanva").transform.parent = null;
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				GameObject.Find ("dhanva").transform.DORotate (new Vector3 (0f, 0f, 190f), 0f, RotateMode.Fast).SetDelay (.7f);
				GameObject.Find ("dhanva").transform.DOMove (GameObject.Find("kaln_layer").transform.position,.4f,false).SetDelay(1f).OnComplete(bow);
				//GameObject.Find ("kl_par").GetComponent<ParticleSystem> ().Play ();
				//GameObject.Find ("add").GetComponent<AudioSource> ().PlayDelayed (.5f);
				//GameObject.Find ("klane").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				//GameObject.Find ("kaln_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("dhanva bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(2.5f).OnComplete(partical);
				GameObject.Find ("dhanva bowl").transform.DOMoveX (8f,1f).SetDelay(2.7f);
				DOTween.Play ("6");
			}
		}

		if (gameObject.transform.name == "poodena bowl") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("poodena bowl").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("poodena bowl").GetComponent<Drag> ());
				GameObject.Find ("poodena bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("poodena bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);
				GameManager.Instance.bl = 3;
				//GameObject.Find ("dhanva").transform.parent = null;
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				GameObject.Find ("pooden").transform.DORotate (new Vector3 (0f, 0f, 190f), 0f, RotateMode.Fast).SetDelay (.7f);
				GameObject.Find ("pooden").transform.DOMove (GameObject.Find("kaln_layer").transform.position,.4f,false).SetDelay(1f).OnComplete(bow);
				//GameObject.Find ("kl_par").GetComponent<ParticleSystem> ().Play ();
				//GameObject.Find ("add").GetComponent<AudioSource> ().PlayDelayed (.5f);
				//GameObject.Find ("klane").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				//GameObject.Find ("kaln_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("poodena bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(2.5f).OnComplete(partical);
				GameObject.Find ("poodena bowl").transform.DOMoveX (8f,1f).SetDelay(2.7f);
				DOTween.Play ("6");
			}
		}
		if (gameObject.transform.name == "mirch bowl") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("mirch bowl").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("mirch bowl").GetComponent<Drag> ());
				GameObject.Find ("mirch bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("mirch bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);
				GameManager.Instance.bl = 4;
				//GameObject.Find ("dhanva").transform.parent = null;
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);
				GameObject.Find ("mirch").transform.DORotate (new Vector3 (0f, 0f, 190f), 0f, RotateMode.Fast).SetDelay (.7f);
				GameObject.Find ("mirch").transform.DOMove (GameObject.Find("kaln_layer").transform.position,.4f,false).SetDelay(1f).OnComplete(bow);
				//GameObject.Find ("kl_par").GetComponent<ParticleSystem> ().Play ();
				//GameObject.Find ("add").GetComponent<AudioSource> ().PlayDelayed (.5f);
				//GameObject.Find ("klane").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				//GameObject.Find ("kaln_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("mirch bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(2.5f).OnComplete(partical);
				GameObject.Find ("mirch bowl").transform.DOMoveX (8f,1f).SetDelay(2.9f);
				DOTween.Play ("6");
			}
		}
		if (gameObject.transform.name == "zeera bowl") {


			if (curPosition.x > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("blender").GetComponent<SpriteRenderer> ().bounds.max.y) {
				Debug.Log ("in bowl");
				GameObject.Find ("zeera bowl").GetComponent<iTween> ().enabled = false;
				Destroy (GameObject.Find ("zeera bowl").GetComponent<Drag> ());
				GameObject.Find ("zeera bowl").transform.DORotate (new Vector3 (0f, 0f, 60f), 0f, RotateMode.Fast).SetDelay(.3f);
				GameObject.Find ("zeera bowl").transform.DOMove (GameObject.Find("E").transform.position,.4f,false);
				GameManager.Instance.bl = 5;
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed(.1f);

				GameObject.Find ("ze_par").GetComponent<ParticleSystem> ().Play ();
				GameObject.Find ("add").GetComponent<AudioSource> ().PlayDelayed (.5f);
				GameObject.Find ("zeera").transform.DOScale (new Vector2(0f,0f),2f).SetDelay(.5f);
				GameObject.Find ("zera_layer").transform.DOScale (new Vector2(1f,1f),2f).SetDelay(1f).OnComplete(partical);

				GameObject.Find ("zeera bowl").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay(2.5f);
				GameObject.Find ("zeera bowl").transform.DOMoveX (8f,1f).SetDelay(2.7f).OnComplete(bow);
				DOTween.Play ("120");
			}
		}
		// Spoon 
		if (gameObject.transform.name == "spoon1") {


			if (curPosition.x > GameObject.Find ("bowl").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("bowl").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("bowl").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("bowl").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				if (GameManager.Instance.p == 0) {
					Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer").transform.position;
					GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon1").transform.DOMove (GameObject.Find ("E").transform.position, .4f, false);
					GameManager.Instance.bl = 1;
					GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2 (0.9f, 0.9f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp1);
				}
				if (GameManager.Instance.p == 1) {
					Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer").transform.position;
					GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon1").transform.DOMove (GameObject.Find ("E").transform.position, .4f, false);
					GameManager.Instance.bl = 2;
					GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2 (0.8f, 0.8f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp1);
				}
				if (GameManager.Instance.p == 2) {
					Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer").transform.position;
					GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon1").transform.DOMove (GameObject.Find ("E").transform.position, .4f, false);
					GameManager.Instance.bl = 3;
					GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2 (0.7f, 0.7f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp1);
				}
				if (GameManager.Instance.p == 3) {
					Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer").transform.position;
					GameObject.Find ("bowl").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon1").transform.DOMove (GameObject.Find ("E").transform.position, .4f, false);
					GameManager.Instance.bl = 4;
					GameObject.Find ("spoon1").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("Mixing_layer").transform.DOScale (new Vector2 (.6f, .6f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp1);
				}

			}
			if (curPosition.x > GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("m1").transform.position;
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon1").transform.DOMove (new Vector3(0.6f,0.25f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("m1").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("mixer").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp2);

			}
			if (curPosition.x > GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon1").transform.DOMove (new Vector3(-0.4f,-0.88f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("m2").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("m2").transform.position;

				GameObject.Find ("mixer").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp2);

			}
			if (curPosition.x > GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon1").transform.DOMove (new Vector3(1.76f,-0.75f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("m3").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("m3").transform.position;

				GameObject.Find ("mixer").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp2);

			}
			if (curPosition.x > GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon1").GetComponent<Drag> ());
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon1").transform.DOMove (new Vector3(0.53f,-1.48f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("m4").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("m4").transform.position;

				GameObject.Find ("mixer").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("spoon1").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp2);

			}
		}

		//spoon2
		if (gameObject.transform.name == "spoon2") {


			if (curPosition.x > GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in bowl");
				if (GameManager.Instance.p == 0) {
					Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
					GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon2").transform.DOMove (GameObject.Find ("E1").transform.position, .4f, false);
					GameManager.Instance.bl = 1;
					GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("water_layer").transform.DOScale (new Vector2 (0.9f, 0.9f), 0f).SetDelay (.5f);


					GameObject.Find ("mixer2").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer2").transform.position;
					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp3);
				}
				if (GameManager.Instance.p == 1) {
					Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
					GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon2").transform.DOMove (GameObject.Find ("E1").transform.position, .4f, false);
					GameManager.Instance.bl = 2;
					GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("water_layer").transform.DOScale (new Vector2 (0.8f, 0.8f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer2").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer2").transform.position;

					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp3);
				}
				if (GameManager.Instance.p == 2) {
					Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
					GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon2").transform.DOMove (GameObject.Find ("E1").transform.position, .4f, false);
					GameManager.Instance.bl = 3;
					GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("water_layer").transform.DOScale (new Vector2 (0.7f, 0.7f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer2").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer2").transform.position;

					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp3);
				}
				if (GameManager.Instance.p == 3) {
					Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
					GameObject.Find ("BOWL-1").GetComponent<BoxCollider> ().enabled = false;
					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
					GameObject.Find ("spoon2").transform.DOMove (GameObject.Find ("E1").transform.position, .4f, false);
					GameManager.Instance.bl = 4;
					GameObject.Find ("spoon2").GetComponent<SpriteRenderer> ().sortingOrder = 3;
					GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
					GameObject.Find ("water_layer").transform.DOScale (new Vector2 (.6f, .6f), 0f).SetDelay (.5f);
					GameObject.Find ("mixer2").transform.DOScale (new Vector2 (1f, 1f), .5f).SetDelay (1f).OnComplete (partical);
					GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("mixer2").transform.position;

					GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp3);
				}

			}
			if (curPosition.x > GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri1").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon2").transform.DOMove (new Vector3(0.6f,0.25f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("w1").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("mixer2").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("w1").transform.position;

				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp4);

			}
			if (curPosition.x > GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri2").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon2").transform.DOMove (new Vector3(-0.4f,-0.88f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("w2").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("mixer2").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("w2").transform.position;

				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp4);

			}
			if (curPosition.x > GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri3").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon2").transform.DOMove (new Vector3(1.76f,-0.75f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("w3").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("mixer2").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("w3").transform.position;

				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp4);

			}
			if (curPosition.x > GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.min.x &&
				curPosition.y > GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.min.y &&
				curPosition.x < GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.max.x &&
				curPosition.y < GameObject.Find ("puri4").GetComponent<BoxCollider> ().bounds.max.y) {
				Debug.Log ("in puri");

				Destroy (GameObject.Find ("spoon2").GetComponent<Drag> ());
				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 18f), 0f, RotateMode.Fast).SetDelay (.3f);
				GameObject.Find ("spoon2").transform.DOMove (new Vector3(0.53f,-1.48f,0f), .4f, false);
				GameObject.Find ("pop").GetComponent<AudioSource> ().PlayDelayed (.1f);
				GameObject.Find ("w4").transform.DOScale (new Vector2 (1f, 1f), 0f).SetDelay (.5f);
				GameObject.Find ("mixer2").transform.DOScale (new Vector2 (0f, 0f), .4f).SetDelay (.5f).OnComplete (partical);
				GameObject.Find ("p_btn_1").transform.position = GameObject.Find ("w4").transform.position;

				GameObject.Find ("spoon2").transform.DORotate (new Vector3 (0f, 0f, 0f), 0f, RotateMode.Fast).SetDelay (2f).OnComplete (spp4);

			}
		}


		if(ActionMoveEvent != null)
				ActionMoveEvent();	
	}
	//On action up of the sprite/gameobject .
	void OnMouseUp(){
		Cursor.visible = true;

		if (gameObject.transform.name == "blender") {
			GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Pause ();
			GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Stop();
			GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().Stop();
			GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop();
			gameObject.transform.position = pos2;
		}
		if (gameObject.transform.name == "Blender") {
			GameObject.Find ("Mixing_layer").GetComponent<tk2dSpriteAnimator> ().Pause ();
			GameObject.Find ("Mixer (1)").GetComponent<AudioSource> ().Stop();
			GameObject.Find ("blender").GetComponent<tk2dSpriteAnimator> ().Stop();
			GameObject.Find ("bul").GetComponent<ParticleSystem> ().Stop();
			gameObject.transform.position = pos2;
		}
		if (gameObject.transform.name == "rolling") {

			DOTween.PauseAll ();

			GameObject.Find ("ro").GetComponent<AudioSource> ().Stop();
		}
		if (gameObject.transform.name == "lemon1") {

			GameObject.Find ("lemon1").GetComponent<SpriteRenderer> ().sortingOrder = 6;
			gameObject.transform.position = pos;
		}
		if (gameObject.transform.name == "lemon2") {

			GameObject.Find ("lemon2").GetComponent<SpriteRenderer> ().sortingOrder = 6;
			gameObject.transform.position = pos;
		}
		if (gameObject.transform.name == "lemon3") {

			GameObject.Find ("lemon3").GetComponent<SpriteRenderer> ().sortingOrder = 6;
			gameObject.transform.position = pos;
		}


		else {
			gameObject.transform.position = pos;
		}


	//	gameObject.transform.position=pos;

		if(ActionUpEvent != null)
			ActionUpEvent();	
	}

	void spp1()
	{
	
		GameObject.FindObjectOfType<SceneSix> ().sp1 ();
	}
	void spp2()
	{

		GameObject.FindObjectOfType<SceneSix> ().sp2 ();
	}
	void spp3()
	{

		GameObject.FindObjectOfType<SceneSix> ().sp3 ();
	}
	void spp4()
	{

		GameObject.FindObjectOfType<SceneSix> ().sp4();
	}
	void partical()
	{
	
		GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
		GameObject.Find ("item2 (1)").GetComponent<AudioSource> ().Play ();
	
	}

	void jug ()
	{
		Debug.Log ("watewr");
		GameObject.Find ("water1").GetComponent<SpriteRenderer> ().sprite = GameObject.FindObjectOfType<mixing_scen1> ().jug1;
		
	}
	void jug1 ()
	{
		GameObject.Find("water1").GetComponent<SpriteRenderer>().sprite=GameObject.FindObjectOfType<mixing_scen1> ().jug2;

	}

	void rolarmove()
	{
		Destroy (GameObject.Find("rolling").GetComponent<Drag>());
	
		GameObject.Find ("rolling").transform.DOMoveX (10f,1f,false).OnComplete(tl);
		if (a == false) {
			a = true;
			Debug.Log ("rolling ");
			GameObject.Find ("p_btn_1").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("item2 (1)").GetComponent<AudioSource> ().Play ();

			GameObject.Find ("ro").GetComponent<AudioSource> ().Stop();
			GameObject.Find ("awesome (1)").GetComponent<AudioSource> ().Play ();
		}


	}

	void tool ()
	{

		GameObject.FindObjectOfType<SceneTwo> ().doch ();
	}
	void tl()
	{
		GameObject.Find ("do2").transform.parent = null;
		GameObject.Find ("do1").transform.parent = null;
		GameObject.Find ("griddle_down").transform.DORotate (new Vector3(0f,0f,0f),.5f,RotateMode.Fast);
		GameObject.Find ("griddle_down").transform.DOMoveX (10f,1f,false).OnComplete(pt);
		DOTween.Play ("50");
		//GameObject.FindObjectOfType<SceneTwo>().rol();

	}

	void fr()
	{
		GameObject.FindObjectOfType<SceneThree> ().frying ();
	}
	void pt()
	{

		if (b == false) {
		
			b = true;
			GameObject.Find ("p_btn_1 (1)").GetComponent<ParticleSystem> ().Play ();
			GameObject.Find ("item2 (1)").GetComponent<AudioSource> ().Play ();
			GameObject.Find ("awesome (1)").GetComponent<AudioSource> ().Play ();
		}
	}

	void Lemo()
	{

		GameObject.FindObjectOfType<SceneFive> ().lemo ();
	}

	void bow()
	{

		if (GameManager.Instance.bl == 1) {
			if (x==false) {
				x = true;
				GameObject.Find ("dhanva bowl").AddComponent<Drag> ();
			}
			GameObject.Find ("dhanva bowl").GetComponent<ScaleBtnEffect> ().enabled = true;
		
		}
		if (GameManager.Instance.bl == 2) {
			if (y==false) {
				y = true;
				GameObject.Find ("poodena bowl").AddComponent<Drag> ();
			}
			GameObject.Find ("poodena bowl").GetComponent<ScaleBtnEffect> ().enabled = true;
			GameObject.Find ("dhanva").transform.parent = GameObject.Find ("blender").transform;
			//GameObject.Find ("pooden").transform.parent = GameObject.Find ("blender").transform;
		}
		if (GameManager.Instance.bl == 3) {
			if (z==false) {
				z = true;
				GameObject.Find ("mirch bowl").AddComponent<Drag> ();
			}
			GameObject.Find ("mirch bowl").GetComponent<ScaleBtnEffect> ().enabled = true;
			GameObject.Find ("pooden").transform.parent = GameObject.Find ("blender").transform;

		}
		if (GameManager.Instance.bl == 4) {
			GameObject.Find ("mirch").transform.parent = GameObject.Find ("blender").transform;
			if (t==false) {
				t = true;
				GameObject.Find ("zeera bowl").AddComponent<Drag> ();
			}
			GameObject.Find ("zeera bowl").GetComponent<ScaleBtnEffect> ().enabled = true;

			//GameObject.Find ("mirch").transform.parent = GameObject.Find ("blender").transform;
		}
		if (GameManager.Instance.bl == 5) {
			GameObject.Find ("off").GetComponent<tk2dButton> ().enabled = true;
		}
	}
}
