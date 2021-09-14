using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parcaSize : MonoBehaviour
{
    Vector3 size;
    public static float speed;
    void Start()
    {
        size = transform.localScale;
        size.x = cutting.count;
        transform.localScale = size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
