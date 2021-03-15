using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLite : MonoBehaviour
{
   public GameObject changemainlite;
    public Sprite mainlite2, mainlite;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeImage());
        // changemainlite.GetComponent<SpriteRenderer>().sprite = mainlite;
    }

    // Update is called once per frame
    void Update()
    {
       // changemainlite.GetComponent<SpriteRenderer>().sprite = mainlite2;
    }
    IEnumerator ChangeImage()
    {
        yield return new WaitForSeconds(1f);
        changemainlite.GetComponent<SpriteRenderer>().sprite = mainlite;
        StartCoroutine(ChangeImage2());

    }
    IEnumerator ChangeImage2()
    {
        yield return new WaitForSeconds(1f);
        changemainlite.GetComponent<SpriteRenderer>().sprite = mainlite2;
        StartCoroutine(ChangeImage());
    }
}
