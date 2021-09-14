using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI ScoreeText;
    public int count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = DirtAnim.score;
        ScoreeText.text = count.ToString();
    }
}
