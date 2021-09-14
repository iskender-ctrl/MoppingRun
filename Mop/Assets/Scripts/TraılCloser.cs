using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraılCloser : MonoBehaviour
{
    bool control;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="trail")
        {
            gameObject.GetComponent<TrailRenderer>().emitting = false;
         
        }
        if (other.gameObject.tag == "start")
        {
            gameObject.GetComponent<TrailRenderer>().emitting = true;

        }
       
        /*else
        {
            gameObject.GetComponent<TrailRenderer>().emitting = true;
        }

    */
    }
    public void clean()
    {
       
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(0.01f);
       
        StopCoroutine(timer());
    }

}
