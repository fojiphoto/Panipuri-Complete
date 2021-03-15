using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eyes : MonoBehaviour
{
    public Image eye;
    public GameObject eyechange;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EyeChange1());
    }
    IEnumerator EyeChange1()
    {
        yield return new WaitForSeconds(3f);
        eyechange.GetComponent<Image>().sprite = eye.sprite;
        StartCoroutine(cahngeeye2());
    }
    IEnumerator cahngeeye2()
    {
        yield return new WaitForSeconds(2f);
        eyechange.GetComponent<Image>().sprite = eye.sprite;
        StartCoroutine(EyeChange1());
    }
}
