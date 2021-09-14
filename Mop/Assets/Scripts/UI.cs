using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject good;
    public GameObject nice;
    public GameObject awasome;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="good1")
        {
            good.SetActive(true);
            StartCoroutine(ExampleCoroutine());
            nice.SetActive(false);
            awasome.SetActive(false);
        }
        if(col.gameObject.tag=="nice1")
        {
            nice.SetActive(true);
            StartCoroutine(ExampleCoroutine());
            good.SetActive(false);
            awasome.SetActive(false);
        }
        if(col.gameObject.tag=="awasome1")
        {
            awasome.SetActive(true);
            StartCoroutine(ExampleCoroutine());
            good.SetActive(false);
            nice.SetActive(false);
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
        good.SetActive(false);
        nice.SetActive(false);
        awasome.SetActive(false);
        //After we have waited 5 seconds print the time again.
    }
}
