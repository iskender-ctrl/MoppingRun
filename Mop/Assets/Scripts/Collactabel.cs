using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collactabel : MonoBehaviour
{
    public static int count;
    public static int score;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mop")
        {
            Destroy(gameObject);
        }
    }
}
