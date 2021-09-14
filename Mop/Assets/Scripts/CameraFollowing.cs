using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    Transform boy_position;
    Vector3 distance;
    public static int CamSpeed;
    void Start()
    {
        CamSpeed = 4;
        boy_position = GameObject.Find("PlayerWithSlimb").transform;
    }


    void LateUpdate()
    {
        distance = new Vector3(-4.7f, boy_position.position.y + 16, boy_position.position.z  -18f);

        transform.position = Vector3.Lerp(transform.position, distance,CamSpeed* Time.deltaTime);

    }
}

