using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeParticle : MonoBehaviour
{
    public ParticleSystem part1, part2,part3,part4,part5,part6,part7,part8,part9;
    public Transform mop;
    void Start()
    {
        part1.Stop();
        part2.Stop();
        part3.Stop();
        part4.Stop();
        part5.Stop();
        part6.Stop();
        part7.Stop();
        part8.Stop();
        part9.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="camur")
        {
            Debug.Log("afagdbdfbgg");
            part1.Play();
            part2.Play();
            part3.Play();
            part4.Play();
            part5.Play();
            part6.Play();
            part7.Play();
            part8.Play();
            part9.Play();
        }
        else
        {
            part1.Stop();
            part2.Stop();
            part3.Stop();
            part4.Stop();
            part5.Stop();
            part6.Stop();
            part7.Stop();
            part8.Stop();
            part9.Stop();
        }
    }

}
