using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade : MonoBehaviour
{
    public GameObject Rmop;
    public GameObject Lmop;
    public Transform pos;
    public ParticleSystem cut;
    public float speed;
    public GameObject gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "right")
        {
            cutting.count-=1.3f*speed;
            ColSize.speed = -1;
            mopSize.Cutspeed = 1;
            StartCoroutine(timer());
            StartCoroutine(timer2());
            cut.Play();
            Instantiate(Rmop, pos.position,Quaternion.identity);
            
        }
        if (other.gameObject.tag == "left")
        {
            
            cutting.count2-=1f*speed;
            ColSize.speed = -1;
            mopSize.Cutspeed = 1;
            StartCoroutine(timer());
            StartCoroutine(timer2());
            cut.Play();
            Instantiate(Lmop, pos.position, Quaternion.identity);
        }
        if (other.gameObject.name=="Mesh (11).001")
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
        /*if (other.gameObject.tag == "mop")
        {
     
            ColSize.speed -= 1;
            mopSize.Cutspeed = 1;
            StartCoroutine(timer());
        }
    */}
   
    IEnumerator timer()
    {
        yield return new WaitForSeconds(0.1f);
        mopSize.speed = 0;
        mopSize.Cutspeed = 0;
        ColSize.speed = 0;
        speed = 0;
        StopCoroutine(timer());
    }
    IEnumerator timer2()
    {
        yield return new WaitForSeconds(0.5f);
        
        StopCoroutine(timer2());
    }
}
