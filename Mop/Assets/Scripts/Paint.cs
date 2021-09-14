using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public GameObject brush;
    public Transform mop;
    public float brushsize = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       /* var paint = Instantiate(brush, mop.position+ Vector3.up * 0.1f, Quaternion.identity, transform);
        paint.transform.localScale = Vector3.one * brushsize;
        /*if (Input.GetMouseButton(0))
        {
            //cast a ray to the plane
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                //instanciate a brush
               
            }

        }*/

    }
}
