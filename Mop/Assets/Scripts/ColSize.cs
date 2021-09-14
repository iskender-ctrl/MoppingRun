using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColSize : MonoBehaviour
{
    public BoxCollider col;
    Vector3 size;
    public static float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*size = col.transform.localScale;
        size.x += speed * Time.deltaTime;
        col.transform.localScale = size;
    */}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="camur")
        {
            col.size += new Vector3(cutting.count, 0, 0);
        }
        if (other.gameObject.tag == "blade")
        {
            col.size -= new Vector3(cutting.count, 0, 0);
        }
    }
}
