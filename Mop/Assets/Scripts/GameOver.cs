using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject levelBar;
    public GameObject good;
    public GameObject nice;
    public GameObject awasome;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver.activeInHierarchy==true)
        {
            levelBar.SetActive(false);
            good.SetActive(false);
            nice.SetActive(false);
            awasome.SetActive(false);
        }
        else
        {
            levelBar.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
            levelBar.SetActive(false);
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
