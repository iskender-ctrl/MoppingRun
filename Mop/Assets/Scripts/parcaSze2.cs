using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parcaSze2 : MonoBehaviour
{
    Vector3 size;
    public static float speed;
    void Start()
    {
        size = transform.localScale;
        size.x = cutting.count2;
        Debug.Log(size.x);
        transform.localScale = size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
