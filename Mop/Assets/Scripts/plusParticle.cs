using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusParticle : MonoBehaviour
{
    public ParticleSystem plus, plus1, sour, sour1, sour2, sour3;
    void Start()
    {
        plus.Stop();
        plus1.Stop();
        sour.Stop();
        sour1.Stop();
        sour2.Stop();
        sour3.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer==LayerMask.NameToLayer("plusRight"))
        {
            plus.Play();
        }

        if (col.gameObject.layer==LayerMask.NameToLayer("plusLeft"))
        {
            plus1.Play();
        }
        if (col.gameObject.layer==LayerMask.NameToLayer("blasterLeft"))
        {
            sour.Play();
        }
        if (col.gameObject.layer==LayerMask.NameToLayer("blasterRight"))
        {
            sour1.Play();
        }
        if (col.gameObject.tag=="objectRight")
        {
            sour2.Play();
        }
        if (col.gameObject.tag=="objectLeft")
        {
            sour3.Play();
        }
    }
}
