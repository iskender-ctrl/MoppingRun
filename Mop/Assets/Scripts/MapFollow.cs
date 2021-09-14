using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapFollow : MonoBehaviour
{
    Transform boy_position;
    Vector3 distance;
    public static int CamSpeed;
    void Start()
    {
        CamSpeed = 1;
        boy_position = GameObject.Find("PlayerWithSlimb").transform;
    }


    void LateUpdate()
    {
        distance = new Vector3(boy_position.position.x, boy_position.position.y , boy_position.position.z);

        transform.position = Vector3.Lerp(transform.position, distance, CamSpeed * Time.deltaTime);

    }
}
