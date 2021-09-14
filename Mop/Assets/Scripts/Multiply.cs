using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Multiply : MonoBehaviour
{
    public static int multi;
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = multi.ToString();
    }
}
