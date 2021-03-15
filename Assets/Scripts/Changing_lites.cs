using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Changing_lites : MonoBehaviour
{
    public Image Tree_image1, Table_image1,Top_image1,Tree_image2, Table_image2,Top_image2;
    public GameObject TreeChange, TableChange, TopChange;
  //  public Sprite Change_Image;
   // int y;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeImage());
        // y = SceneManager.GetActiveScene().buildIndex;
        // if(y==3)
        //  {
        // StartCoroutine(ChangeImage());
        // }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
   
    IEnumerator ChangeImage()
    {

        //    if(y==3)
        //   {
        Debug.Log("In coroutine1");
            yield return new WaitForSeconds(1f);
        TreeChange.GetComponent<Image>().sprite = Tree_image1.sprite;
            // source_image = Change.GetComponent<Image>();
            // source_image.sprite = Change_Image;
        yield return new WaitForSeconds(2f);
        TableChange.GetComponent<Image>().sprite = Table_image1.sprite;
            //changeTop.GetComponent<Image>().sprite = changetoplit1.sprite;
            yield return new WaitForSeconds(3f);
        TopChange.GetComponent<Image>().sprite = Top_image1.sprite;
        StartCoroutine(ChangeImage2());
         //  changeTree.GetComponent<Image>().sprite = changeTreelite1.sprite;
           // StartCoroutine(ChangeImage2());
          //  yield return new WaitForSeconds(3f);
           // changemainlite.GetComponent<Image>().sprite = mainlite.sprite;
             //changemainlite.GetComponent<Image>().sprite = mainlite.sprite;
             //StartCoroutine(ChangeImage2());

       // }
    }
    IEnumerator ChangeImage2()
    {
        // if(y==3)
        // {
        Debug.Log("In coroutine2");

        yield return new WaitForSeconds(1f);
        TreeChange.GetComponent<Image>().sprite = Tree_image2.sprite;
        yield return new WaitForSeconds(2f);
        TableChange.GetComponent<Image>().sprite = Table_image2.sprite;
        yield return new WaitForSeconds(3f);
        TopChange.GetComponent<Image>().sprite = Top_image2.sprite;
        StartCoroutine(ChangeImage());
        // changeTree.GetComponent<Image>().sprite = changeTreelite2.sprite;
        //  changemainlite.GetComponent<Image>().sprite = mainlite2.sprite;

        // yield return new WaitForSeconds(3f);
        //  changemainlite.GetComponent<Image>().sprite = mainlite2.sprite;
       // StartCoroutine(ChangeImage());
       // }
    }
   
}

