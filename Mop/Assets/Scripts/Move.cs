using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject play;
    public static float speed = 12f;
    public Rigidbody player;
    void Awake()
    {

    }
    private void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + (speed * Time.deltaTime));

    }
    public void Play()
    {
        Time.timeScale = 1;
        play.SetActive(false);
    }
}
