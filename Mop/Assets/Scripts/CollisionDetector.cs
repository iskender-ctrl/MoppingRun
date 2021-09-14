using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public static int Score;
    
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "camur")
        {
            gameObject.transform.localScale += new Vector3(1f, 0, 0);
            Score++;
            Destroy(obj.gameObject, 0.2f);
        }
       
    }
}
