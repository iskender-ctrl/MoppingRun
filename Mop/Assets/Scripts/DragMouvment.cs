using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouvment : MonoBehaviour
{
    private Touch touch;
    public float speedMofifiare;
    Transform player;
    public Rigidbody play;
    void Start()
    {
        player = GameObject.Find("PlayerWithSlimb").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved)
            {
              
                if (player.position.x >= -2  || player.position.x <= -7)
                {
                    speedMofifiare = 0;
                    if(player.position.x <= -7)
                    {
                        player.transform.position = new Vector3(player.transform.position.x + 0.1f, player.transform.position.y, player.transform.position.z);
                    }
                    else
                    {
                        player.transform.position = new Vector3(player.transform.position.x - 0.1f, player.transform.position.y, player.transform.position.z);
                    }
                   
                }
                else
                {
                    speedMofifiare = 0.2f;
                }
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMofifiare*Time.deltaTime, transform.position.y,transform.position.z);
                if (touch.phase == TouchPhase.Stationary)
                {
                    
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMofifiare * Time.deltaTime, transform.position.y, transform.position.z );
                }
            }
           
        }
    }
}