using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainScore : MonoBehaviour
{
    public TextMeshProUGUI count;
    public int sayac;
    public static int carpan;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayac = DirtAnim.score*carpan;
        count.text = sayac.ToString();
    }
}
