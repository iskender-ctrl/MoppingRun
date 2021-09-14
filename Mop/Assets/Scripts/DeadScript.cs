using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject levelBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnColliderEnter(Collider col)
    {
        if (col.gameObject.tag=="blade")
        {
            levelBar.SetActive(false);
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
