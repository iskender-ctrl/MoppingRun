using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSize : MonoBehaviour
{
    BoxCollider bx;
    GameObject Mop;
    void Start()
    {
        bx = GetComponent<BoxCollider>();
        Mop = GameObject.Find("Mop");
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "camur")
        {
            bx.size = new Vector3(Mop.transform.localScale.x, 3.001757f, 3.302059f);
        }
        if (other.gameObject.tag == "saw")
        {
            bx.size = new Vector3(Mop.transform.localScale.x, 3.001757f, 3.302059f);
        }
    }
}
