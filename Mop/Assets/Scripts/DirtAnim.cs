using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtAnim : MonoBehaviour
{
    public ParticleSystem dirt;
    public Animator col;
    public string colS;
    //public static int count;
    public static int score;
    void Start()
    {
        dirt.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mop")
        {

         
            score+=5;
           // count++;
          
        }
    }

}
