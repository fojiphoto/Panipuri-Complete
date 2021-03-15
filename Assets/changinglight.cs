using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changinglight : MonoBehaviour
{
    public Sprite Change_image, Change_image1, changetoplit1, changetoplit2, changeTreelite1, changeTreelite2;
    public GameObject Change, changeTop, changeTree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  /*  void Update()
    {
        yield return new WaitForSeconds(1f);
        Change.GetComponent<SpriteRenderer>().sprite = Change_image;
        yield return new WaitForSeconds(2f);
        changeTop.GetComponent<SpriteRenderer>().sprite = changetoplit1;
        yield return new WaitForSeconds(3f);
        changeTree.GetComponent<SpriteRenderer>().sprite = changeTreelite1;
        //  StartCoroutine(ChangeImage2());
        yield return new WaitForSeconds(3f);
    }*/
}
