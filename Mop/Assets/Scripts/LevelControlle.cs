using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlle : MonoBehaviour
{
    public GameObject win;
    public GameObject lose;
    public GameObject awsome;
    public GameObject well;
    public GameObject good;
    public GameObject character;
    public GameObject cam;
    public GameObject fog;
    public GameObject bar;
    void Start()
    {
        bar.gameObject.SetActive(true);
        win.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //lose.gameObject.SetActive(true);
        // well.gameObject.SetActive(true);
       // awsome.gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="x1")
        {
            MainScore.carpan = 1;
            Move.speed = 0;
            good.gameObject.SetActive(true);
            CameraFollowing.CamSpeed = 0;
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 1;
            StartCoroutine(timer());
        }
        if(other.gameObject.tag=="x2")
        {
            Debug.Log("good");
            Move.speed = 0;
            good.gameObject.SetActive(true);
            MainScore.carpan = 2;
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 2;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x3")
        {
            MainScore.carpan = 3;
            Move.speed = 0;
            good.gameObject.SetActive(true);
            Debug.Log("well");
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 3;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x4")
        {
            MainScore.carpan = 4;
            Move.speed = 0;
            Debug.Log("nice");
            good.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 4;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x5")
        {
            MainScore.carpan = 5;
            Move.speed = 0;
            Debug.Log("nice");
            good.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 5;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x6")
        {
            MainScore.carpan = 6;
            Move.speed = 0;
            CameraFollowing.CamSpeed = 0;
            good.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 6;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x7")
        {
            MainScore.carpan = 7;
            Move.speed = 0;
            Debug.Log("good");
            well.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 7;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x8")
        {
            MainScore.carpan = 8;
            Move.speed = 0;
            Debug.Log("well");
            well.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 8;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x9")
        {
            MainScore.carpan = 9;
            Move.speed = 0;
            Debug.Log("nice");
            well.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 9;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x10")
        {
            MainScore.carpan = 10;
            Move.speed = 0;
            Debug.Log("nice");
            well.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            Time.timeScale = 0;
            Multiply.multi = 10;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x11")
        {
            MainScore.carpan = 11;
            Move.speed = 0;
            Debug.Log("nice");
            awsome.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            //cam.transform.position = new Vector3(-3.43f, character.transform.position.y + 10f, character.transform.position.z - 16f);
            Time.timeScale = 0;
            Multiply.multi = 11;
            StartCoroutine(timer());
        }
        if (other.gameObject.tag == "x12")
        {
            MainScore.carpan = 12;
            Move.speed = 0;
            Debug.Log("nice");
            awsome.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
            fog.SetActive(false);
            //cam.transform.position = new Vector3(-4.8f, -44.53f, 420.7f);
            Time.timeScale = 0;
            Multiply.multi = 12;
            bar.gameObject.SetActive(false);
            StartCoroutine(timer());
        }
        /*if (other.gameObject.tag == "blade")
        {
            Move.speed = 0;
            lose.gameObject.SetActive(true);
            character.GetComponent<Rigidbody>().useGravity = false;
        }*/
    }
    
    IEnumerator timer()
    {
        yield return new WaitForSeconds(0);
        CameraFollowing.CamSpeed = 0;
        win.gameObject.SetActive(true);
     
    }
}
