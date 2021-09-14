using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loader : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void click()
    {
        Move.speed = 12f;
        SceneManager.LoadScene("level_Deneme");
    }


}
