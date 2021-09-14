using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutting : MonoBehaviour
{
    public static float speed;
    public GameObject mop;
    public GameObject MainMop;
    public Transform pos;
    public static float count;
    public static float count2;
    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "camur")
        {
            speed = 0.04f;
            count+=0.05f*speed;
            count2+= 0.05f*speed;
            mopSize.speed = 1;
            ColSize.speed = 1;
            StartCoroutine(timer2());
            StartCoroutine(timer());
            //MainMop.transform.localScale += new Vector3(count, 0, 0);

        }
       
    }
   IEnumerator timer()
    {
        yield return new WaitForSeconds(0.5f);
        mopSize.speed = 0;
        ColSize.speed = 0;
        StopCoroutine(timer());
    }
  IEnumerator timer2()
    {
        yield return new WaitForSeconds(0.5f);
        speed = 0;
        StopCoroutine(timer2());
    }
}
