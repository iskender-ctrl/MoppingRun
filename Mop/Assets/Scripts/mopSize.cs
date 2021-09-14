using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mopSize : MonoBehaviour
{
    Vector3 size;
    public static int speed;
    public static int Cutspeed;
    public BoxCollider col;
    GameObject Mop;
    public ParticleSystem Dirt;
    public ParticleSystem Dirt2;
    public ParticleSystem Dirt3;
    public ParticleSystem Dirt4;
    public ParticleSystem Dirt5;
    public ParticleSystem Dirt6;
    public ParticleSystem part1, part2;
  
    void Start()
    {
        Mop = GameObject.Find("Mop");
        Dirt.Stop();
        Dirt2.Stop();
        Dirt3.Stop();
        Dirt4.Stop();
        Dirt5.Stop();
        Dirt6.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        MopSize();
        col.size = new Vector3(transform.localScale.x, 2f, 2f);
    }
    void MopSize()
    {
        size = transform.localScale;
        size.x += 2f*speed * Time.deltaTime;
        size.x -= 6f*Cutspeed * Time.deltaTime;
        transform.localScale = size;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="kir")
        {
            Dirt.Play();
            Dirt2.Play();
            Dirt3.Play();
            Dirt4.Play();
            Dirt5.Play();
            Dirt6.Play();
        }
        else
        {
            Dirt.Stop();
            Dirt2.Stop();
            Dirt3.Stop();
            Dirt4.Stop();
            Dirt5.Stop();
            Dirt6.Stop();
        }
        if(other.gameObject.tag=="camur")
        {
        }
    }
   IEnumerator timer()
    {
        yield return new WaitForSeconds(0.5f);
        StopCoroutine(timer());
    }

}
